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

namespace BackEnd_UI.Match
{
    public partial class frmResultats : Form
    {
        public frmResultats()
        {
            InitializeComponent();
            /* ajout des méthodes suivantes dans le initialize component :
                * this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    *permet aux données de remplir le tab
                *
             */
        }

        private void frmResultats_Load(object sender, System.EventArgs e)
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

        //fonction pour charger/recharger le tableau de résultats
        private void gridResults_LoadSelection(object sender, System.EventArgs e)
        {
            try
            {
                //vérification du radiobutton sélectionné pour connaître la saison à afficher
                int ssn = checkRdbtnSelection();
                //récupération de l'ID championnat sélectionné
                MdlChampionnat oChamp = new MdlChampionnat();
                oChamp = (MdlChampionnat) boxChampSelection.SelectedItem;
                //envoi de la requête vers la BL pour remplir le datagridview en fonction du championnat et de la/les saison(s)
                ResultatsServices oResServices = new ResultatsServices();
                List<MdlResultats> lstRes = oResServices.GetResultats(oChamp.Id, ssn);
                gridResults.DataSource = lstRes;
                //cacher les colonnes avec l'ID du type résultat
                gridResults.Columns[5].Visible = false;
                gridResults.Columns[7].Visible = false;
                gridResults.Columns[8].Visible = false;
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

        //double cliquer dans le tableau résultat = ouvrir une fenêtre de modification de la ligne sélectionnée
        private void gridResults_DoubleClick(object sender, System.EventArgs e)
        {
            try
            {
                //ouverture de la fenêtre de modification de résultat
                MdlResultats slctdRes = (MdlResultats) gridResults.CurrentRow.DataBoundItem;
                frmModifResult oFrmModifResult = new frmModifResult(slctdRes);
                oFrmModifResult.MdiParent = this.MdiParent;
                oFrmModifResult.Show();
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
                throw new BusinessErrors(ex.Message);
            }

        }

    }
}
