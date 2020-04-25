using BackEnd_BL;
using Errors;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd_UI.Calendrier
{
    public partial class frmCalendrier : Form
    {
        public frmCalendrier()
        {
            InitializeComponent();
        }

        private void frmCalendrier_Load(object sender, EventArgs e)
        {
            try
            {
                //chargement de la liste des championnats
                ChampionnatsServices oService = new ChampionnatsServices();
                List<MdlChampionnat> lstChamp = new List<MdlChampionnat>();
                lstChamp = oService.GetChampionnats();
                boxChampSelection.DataSource = lstChamp;
                boxChampSelection.DisplayMember = "NomString";
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }

        }

        private void clndrGrids_Load(object sender, EventArgs e)
        {
            try
            {                
                int slctdSsn;
                //récupération de l'ID championnat sélectionné
                MdlChampionnat oChamp = new MdlChampionnat();
                oChamp = (MdlChampionnat) boxChampSelection.SelectedItem;
                //vérification du radiobutton sélectionné pour connaître la saison à afficher
                if (rdbtnSeason1.Checked == true)
                    slctdSsn = 1;
                else if (rdbtnSeason2.Checked == true)
                    slctdSsn = 2;
                else slctdSsn = 12;
                //envoi de la requête pour charger les tableaux en fonction de la saison sélectionnée
                CalendrierServices oService = new CalendrierServices();
                gridClndrDated.DataSource=oService.GetClndrLists(oChamp.Id, slctdSsn)[0];
                gridClndrDated.Columns[2].Visible = false; gridClndrDated.Columns[4].Visible = false; gridClndrDated.Columns[6].Visible = false;
                gridClndrDated.Columns[3].HeaderText = "Equipe Domicile"; gridClndrDated.Columns[5].HeaderText = "Equipe Visiteuse";
                gridClndrUndated.DataSource = oService.GetClndrLists(oChamp.Id, slctdSsn)[1];
                gridClndrUndated.Columns[2].Visible = false; /*gridClndrUndated.Columns[1].Visible=false;*/ gridClndrUndated.Columns[4].Visible = false; gridClndrUndated.Columns[6].Visible = false;
                gridClndrUndated.Columns[3].HeaderText = "Equipe Domicile"; gridClndrUndated.Columns[5].HeaderText = "Equipe Visiteuse";
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void btnGnrClndr_Click(object sender, EventArgs e)
        {
            try
            {
                int slctdSsn;
                //récupération de l'ID championnat sélectionné
                MdlChampionnat oChamp = new MdlChampionnat();
                oChamp = (MdlChampionnat)boxChampSelection.SelectedItem;
                //vérification du radiobutton sélectionné pour connaître la saison à afficher
                if (rdbtnSeason1.Checked == true)
                    slctdSsn = 1;
                else if (rdbtnSeason2.Checked == true)
                    slctdSsn = 2;
                else slctdSsn = 12;
                //vérifier si le calendrier de la saison sélectionnée peut être (re)généré
                CalendrierServices oServices = new CalendrierServices();
                //si oui, ouvrir une fenêtre en mode Dialog, proposant la génération de championnat
                if (oServices.GnrPossible(out int blckdSsn,oChamp.Id, slctdSsn))
                {
                    frmGnrCalendrier oFrm = new frmGnrCalendrier();
                    oFrm.ShowDialog();
                    //si on a cliqué sur "Sauver"
                    if (oFrm.DialogResult == DialogResult.OK)
                        MessageBox.Show("sauvé");
                    else
                        MessageBox.Show("annulé");
                }
                else
                {
                    throw new Exception($"clndr Ssn {blckdSsn} non générable");
                }

            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }


        }
    }
}
