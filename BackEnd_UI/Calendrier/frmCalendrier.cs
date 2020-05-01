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
                //récupération de l'ID championnat sélectionné
                MdlChampionnat oChamp = new MdlChampionnat();
                oChamp = (MdlChampionnat) boxChampSelection.SelectedItem;
                //vérification du radiobutton sélectionné pour connaître la saison à afficher
                int slctdSsn = checkRdbtnSelection();
                //envoi de la requête pour charger les tableaux en fonction de la saison sélectionnée
                CalendrierServices oService = new CalendrierServices();
                gridClndrDated.DataSource=oService.GetClndrLists(oChamp.Id, slctdSsn)[0];
                gridClndrDated.Columns[2].Visible = false;
                gridClndrDated.Columns[3].Visible = false;
                gridClndrDated.Columns[5].Visible = false; 
                gridClndrDated.Columns[7].Visible = false;
                gridClndrDated.Columns[4].HeaderText = "Equipe Domicile"; 
                gridClndrDated.Columns[6].HeaderText = "Equipe Visiteuse";
                gridClndrUndated.DataSource = oService.GetClndrLists(oChamp.Id, slctdSsn)[1];
                gridClndrUndated.Columns[2].Visible = false;
                gridClndrUndated.Columns[3].Visible = false;
                gridClndrUndated.Columns[5].Visible = false; 
                gridClndrUndated.Columns[7].Visible = false;
                gridClndrUndated.Columns[4].HeaderText = "Equipe Domicile"; 
                gridClndrUndated.Columns[6].HeaderText = "Equipe Visiteuse";
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
                //récupération de l'ID championnat sélectionné
                MdlChampionnat oChamp = new MdlChampionnat();
                oChamp = (MdlChampionnat)boxChampSelection.SelectedItem;
                //vérification du radiobutton sélectionné pour connaître la saison à afficher
                int slctdSsn = checkRdbtnSelection();
                //vérifier si le calendrier de la saison sélectionnée peut être (re)généré
                CalendrierServices oServices = new CalendrierServices();
                //si oui, ouvrir une fenêtre en mode Dialog, proposant la génération de championnat
                if (oServices.GnrPossible(out int blckdSsn,oChamp.Id, slctdSsn))
                {
                    frmGnrCalendrier oFrm = new frmGnrCalendrier(oServices.GetChampSaisons(oChamp.Id),slctdSsn, oChamp.NomString);
                    oFrm.ShowDialog();
                    //si on a cliqué sur "Sauver"
                    if (oFrm.DialogResult == DialogResult.OK)
                        MessageBox.Show("Nouveau calendrier sauvegardé");
                    else
                        MessageBox.Show("Modification annulée");
                }
                else
                {
                    throw new Exception($"clndr Ssn {blckdSsn} non générable");
                }

                clndrGrids_Load(sender,e);
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private int checkRdbtnSelection()
        {
            try
            {
                int slctdBtn;
                //vérification du radiobutton sélectionné pour connaître la saison à afficher
                if (rdbtnSeason1.Checked == true)
                    slctdBtn = 1;
                else if (rdbtnSeason2.Checked == true)
                    slctdBtn = 2;
                else slctdBtn = 12;
                return slctdBtn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }                

        }

        private void gridClndr_DoubleClick(object sender, EventArgs e)
        {
            DataGridView oDatagrid = (DataGridView) sender;
            MdlMatchClndr oMatch = (MdlMatchClndr) oDatagrid.CurrentRow.DataBoundItem;
            string oChamp = boxChampSelection.SelectedText;
            string oSsn = "Saison(s) " + checkRdbtnSelection();
            frmModifCalendrier oFrm = new frmModifCalendrier(oMatch, oChamp, oSsn);
            oFrm.ShowDialog();
            if (oFrm.DialogResult == DialogResult.OK)
                MessageBox.Show("Nouvelle date sauvegardée");
            else
                MessageBox.Show("Modification annulée");
        }

    }
}
