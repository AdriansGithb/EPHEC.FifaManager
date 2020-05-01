using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd_BL;
using Errors;
using Models;

namespace BackEnd_UI
{
    public partial class frmModifCalendrier : Form
    {
        private MdlMatchClndr slctdMatch;
        private MdlSaison oSsn;
        private MdlChampionnat oChamp;
        public frmModifCalendrier(MdlMatchClndr oMatch, MdlChampionnat oChamp, MdlSaison oSsn)
        {
            InitializeComponent();
            this.slctdMatch = oMatch;
            this.oChamp = oChamp;
            this.oSsn = oSsn;
        }

        private void frmModifCalendrier_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnSave.DialogResult = DialogResult.OK;
                lblChampionnat.Text = oChamp.NomString;
                lblSsn.Text = "Saison " + oSsn.FirstOrSecond;
                lblNomEqpDom.Text = slctdMatch.Nom_EqpDom;
                lblNomEqpVst.Text = slctdMatch.Nom_EqpVisit;
                dtTmPckrMatch_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //initialisation du datetimepicker
        private void dtTmPckrMatch_Load()
        {
            try
            {
                //sélection de la date de match si il y en a déjà une
                if (slctdMatch.Date != null)
                {
                    lblPrevDate.Text = ((DateTime)slctdMatch.Date).ToString("D", new CultureInfo("fr-FR"));
                    dtTmPckrMatch.Value = (DateTime)slctdMatch.Date;
                }
                else dtTmPckrMatch.Value = oSsn.Debut;
                //baliser la sélection de date entre le début et la fin de la saison
                CalendrierServices oServices = new CalendrierServices();
                dtTmPckrMatch.MinDate = oSsn.Debut;
                dtTmPckrMatch.MaxDate = oServices.GetEndSsnDate(oSsn.Debut);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtTmPckrMatch_CheckValue(object sender, EventArgs e)
        {
            try
            {
                if (dtTmPckrMatch.Value != slctdMatch.Date)
                {
                    if ((dtTmPckrMatch.Value.DayOfWeek == DayOfWeek.Saturday) ||
                        (dtTmPckrMatch.Value.DayOfWeek == DayOfWeek.Sunday))
                    {
                        MessageBox.Show(
                            "Il n'est pas possible de déplacer un match un jour de w-e",
                            "W-E selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnSave.Enabled = false;
                    }
                    else
                    {
                        CalendrierServices oServices = new CalendrierServices();
                        if (oServices.SelectedDateMatchPossible(dtTmPckrMatch.Value,slctdMatch))
                            this.btnSave.Enabled = true;
                        else
                        {
                            this.btnSave.Enabled = false;
                            MessageBox.Show(
                                "Une des équipes a déjà un match prévu ce jour-là. Veuillez sélectionner une autre date, ou fermer pour quitter.",
                                "Date déjà réservée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else this.btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (slctdMatch.Date == dtTmPckrMatch.Value)
                    throw new BusinessErrors("Date match non modifiée");
                else
                {
                    CalendrierServices oServices = new CalendrierServices();
                    slctdMatch.Date = dtTmPckrMatch.Value;
                    List<MdlMatchClndr> matchAsList = new List<MdlMatchClndr>();
                    matchAsList.Add(slctdMatch);
                    oServices.InsertUpdate_MtchClndr(matchAsList);
                }
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void frmModifCalendrier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled)
            {
                DialogResult oAnswr = MessageBox.Show(
                    "Attention, vous avez sélectionné une nouvelle date valide sans sauvegarder votre changement. Cliquez sur OK pour quitter sans sauver, ou sur Cancel puis Sauver pour sauvegarder votre modification.",
                    "Fermeture sans sauvegarde", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (oAnswr == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
