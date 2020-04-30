using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd_BL;
using Errors;
using Models;

namespace BackEnd_UI.Calendrier
{
    public partial class frmGnrCalendrier : Form
    {
        private List<MdlSaison> champSsnList;
        private int slctdSsn;
        private MdlSaison frstSsn;
        private MdlSaison scndSsn;
        public frmGnrCalendrier(List<MdlSaison> rcvdChampSsnList, int rcvdSlctdSsn, string nomChamp)
        {
            InitializeComponent();
            champSsnList = rcvdChampSsnList;
            slctdSsn = rcvdSlctdSsn;
            lblChampSsn.Text = $"{nomChamp}, saison(s) ";
        }

        private void frmGnrCalendrier_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnSave.DialogResult = DialogResult.OK;
                this.btnSave.Enabled = false;
                this.btnCancel.DialogResult = DialogResult.Cancel;
                if (slctdSsn == 12)
                    lblChampSsn.Text += "1&2";
                else lblChampSsn.Text += slctdSsn;
                splitChampSsnList();
                //si (1ere saison sélectionnée et a déjà un calendrier généré)
                //ou (2e saison sélectionnée et a déjà un calendrier généré)
                //ou (les 2 ssns sélect. et au moins une a un calendrier généré) : charger le calendrier existant
                if ((slctdSsn == 1 && frstSsn.GnrClndr.HasValue)
                    || (slctdSsn == 2 && scndSsn.GnrClndr.HasValue)
                    || (slctdSsn == 12 && (frstSsn.GnrClndr.HasValue || scndSsn.GnrClndr.HasValue)))
                    clndrGrids_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void clndrGrids_Load()
        {
            try
            {
                //envoi de la requête pour charger les tableaux en fonction de la saison sélectionnée
                CalendrierServices oService = new CalendrierServices();
                int champ_id = champSsnList[0].Champ_Id;
                gridClndrDated.DataSource = oService.GetClndrLists(champ_id, slctdSsn)[0];
                gridClndrDated.Columns[2].Visible = false;
                gridClndrDated.Columns[3].Visible = false;
                gridClndrDated.Columns[5].Visible = false;
                gridClndrDated.Columns[7].Visible = false;
                gridClndrDated.Columns[4].HeaderText = "Equipe Domicile";
                gridClndrDated.Columns[6].HeaderText = "Equipe Visiteuse";
                gridClndrUndated.DataSource = oService.GetClndrLists(champ_id, slctdSsn)[1];
                gridClndrUndated.Columns[2].Visible = false; /*gridClndrUndated.Columns[1].Visible=false;*/
                gridClndrUndated.Columns[3].Visible = false;
                gridClndrUndated.Columns[5].Visible = false;
                gridClndrUndated.Columns[7].Visible = false;
                gridClndrUndated.Columns[4].HeaderText = "Equipe Domicile";
                gridClndrUndated.Columns[6].HeaderText = "Equipe Visiteuse";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void splitChampSsnList()
        {
            try
            {
                this.frstSsn = champSsnList.Find(ssn => ssn.FirstOrSecond == 1);
                this.scndSsn = champSsnList.Find(ssn => ssn.FirstOrSecond == 2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnGnrClndr_Click(object sender, EventArgs e)
        {
            try
            {
                List<MdlMatchClndr> nwClndr = new List<MdlMatchClndr>();
                CalendrierServices oServices = new CalendrierServices();
                if (slctdSsn == 12)
                {
                    if(frstSsn.GnrClndr is null && scndSsn.GnrClndr is null)
                        nwClndr = oServices.GenererCalendrier_2Saisons(champSsnList);
                    else
                    {
                        List<MdlMatchClndr> oldClndr = (List<MdlMatchClndr>)gridClndrDated.DataSource;
                        oldClndr.AddRange((List<MdlMatchClndr>)gridClndrUndated.DataSource);
                        List<MdlMatchClndr> oldClndrFirstSsn = oldClndr.FindAll(match=>match.Saison_Id==frstSsn.Id);
                        List<MdlMatchClndr> oldClndrScndSsn = oldClndr.FindAll(match => match.Saison_Id == scndSsn.Id);
                        if (frstSsn.GnrClndr.HasValue && scndSsn.GnrClndr.HasValue)
                        {
                            nwClndr = oServices.RegenererCalendrier_Saison(frstSsn, oldClndrFirstSsn);
                            nwClndr.AddRange(oServices.RegenererCalendrier_Saison(scndSsn, oldClndrScndSsn));
                        }
                        else if (frstSsn.GnrClndr is null)
                        {
                            nwClndr = oServices.GenererCalendrier_Saison(frstSsn);
                            nwClndr.AddRange(oServices.RegenererCalendrier_Saison(scndSsn,oldClndrScndSsn));
                        }
                        else
                        {
                            nwClndr = oServices.RegenererCalendrier_Saison(frstSsn,oldClndrFirstSsn);
                            nwClndr.AddRange(oServices.GenererCalendrier_Saison(scndSsn));
                        }
                    }
                }
                else
                {
                    if (champSsnList.Find(ssn => ssn.FirstOrSecond == slctdSsn).GnrClndr.HasValue)
                    {
                        List<MdlMatchClndr> oldClndr = (List<MdlMatchClndr>) gridClndrDated.DataSource;
                        oldClndr.AddRange((List<MdlMatchClndr>) gridClndrUndated.DataSource);
                        nwClndr = oServices.RegenererCalendrier_Saison(
                            champSsnList.Find(ssn => ssn.FirstOrSecond == slctdSsn), oldClndr);
                    }
                    else
                        nwClndr = oServices.GenererCalendrier_Saison(champSsnList.Find(ssn =>
                            ssn.FirstOrSecond == slctdSsn));
                }
                gridClndrDated.DataSource = nwClndr.FindAll(match => match.Date.HasValue);
                gridClndrUndated.DataSource = nwClndr.FindAll(match => match.Date is null);
                this.btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CalendrierServices oServices = new CalendrierServices();
            List<MdlMatchClndr> saveMatchClndrList = new List<MdlMatchClndr>();
            saveMatchClndrList = (List<MdlMatchClndr>)gridClndrDated.DataSource;
            saveMatchClndrList.AddRange((List<MdlMatchClndr>)gridClndrUndated.DataSource);
            oServices.InsertUpdate_MtchClndr(saveMatchClndrList);
        }
    }
}
