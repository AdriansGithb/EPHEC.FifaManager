using BackEnd_BL;
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
using Errors;

namespace BackEnd_UI.GestionEquipe
{
    public partial class frmTransfertJoueur : Form
    {
        public frmTransfertJoueur()
        {
            InitializeComponent();
        }

        private void frmTransfertJoueur_Load(object sender, EventArgs e)
        {
            try
            {
                boxChampSelection_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }
        
        //charger la liste des championnats dont l'intersaison est en cours
        private void boxChampSelection_Load()
        {
            try
            {
                //chargement de la liste des championnats en cours d'intersaison
                ChampionnatsServices oService = new ChampionnatsServices();
                List<MdlChampionnat> lstChamp = new List<MdlChampionnat>();
                lstChamp = oService.GetInInterssnChampionnats();
                boxChampSelection.DataSource = lstChamp;
                boxChampSelection.DisplayMember = "NomString";
                boxChampSelection.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //charger les 2 listes d'équipes, respectant les conditions de transferts, une fois un championnat sélectionné
        private void boxChampSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                EquipesServices oService = new EquipesServices();
                MdlChampionnat slctdChamp = (MdlChampionnat) boxChampSelection.SelectedItem;
                boxEqpOrgnSelection_Load(slctdChamp);
                boxEqpTrnsfrtSelection_Load(slctdChamp);
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //charger la liste des équipes pouvant transférer un joueur vers une autre équipe
        private void boxEqpOrgnSelection_Load(MdlChampionnat oChamp)
        {
            try
            {
                EquipesServices oService = new EquipesServices();
                boxEqpOrgnSelection.DataSource = oService.GetEqpPouvantTransferer(oChamp.Id);
                boxEqpOrgnSelection.DisplayMember = "Nom";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //charger la liste des équipes pouvant recevoir le transfert d'un joueur depuis une autre équipe
        private void boxEqpTrnsfrtSelection_Load(MdlChampionnat oChamp)
        {
            try
            {
                EquipesServices oService = new EquipesServices();
                boxEqpTrnsfrtSelection.DataSource = oService.GetEqpPouvantRecevoirTrnsfrt(oChamp.Id);
                boxEqpTrnsfrtSelection.DisplayMember = "Nom";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //charger la liste des joueurs de l'équipe d'origine sélectionnée du joueur à transférer
        private void lstbxJoueursEqpOrgn_Load()
        {

        }

        //charger la liste des joueurs de l'équipe dans laquelle le joueur devra être transféré
        private void lstbxJoueursEqpTrnsfrt_Load()
        {

        }

    }
}
