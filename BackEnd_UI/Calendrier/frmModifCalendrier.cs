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

        //chargement des différents objets de la form
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
            catch (BusinessErrors ex)
            {
                MessageBox.Show(ex.Message);
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
                else
                {
                    dtTmPckrMatch.Value = oSsn.Debut;
                    lblPrevDate.Text = ("Aucune");
                }
                //baliser la sélection de date entre le début et la fin de la saison
                CalendrierServices oServices = new CalendrierServices();
                dtTmPckrMatch.MinDate = oSsn.Debut;
                dtTmPckrMatch.MaxDate = oServices.GetEndSsnDate(oSsn.Debut);
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //vérification rapide de la date sélectionnée : pas un jour de WE, et pas un jour où une des équipes a déjà un autre match du même championnat
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
            catch (BusinessErrors ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //sauvegarde de la nouvelle date
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
            catch (BusinessErrors ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }

        }

        //action en cas de fermeture sans avoir sauvé une modification de date
        private void frmModifCalendrier_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (slctdMatch.Date != dtTmPckrMatch.Value)
                {
                    DialogResult oAnswr = MessageBox.Show(
                        "Attention, vous avez sélectionné une nouvelle date valide sans sauvegarder votre changement. Cliquez sur OK pour quitter sans sauver, ou sur Cancel puis Sauver pour sauvegarder votre modification.",
                        "Fermeture sans sauvegarde", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (oAnswr == DialogResult.Cancel)
                        e.Cancel = true;
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
