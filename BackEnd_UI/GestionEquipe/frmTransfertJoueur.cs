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
            try
            {
                MdlEquipeChamp slctdEqp = (MdlEquipeChamp) boxEqpOrgnSelection.SelectedItem;
                JoueursServices oServices = new JoueursServices();
                List<MdlJoueurs> jrList = oServices.GetJoueursEqpList_Ssn2(slctdEqp.Id);
                foreach (MdlJoueurs joueur in jrList)
                {
                    lstbxJoueursEqpOrgn.Items.Add(joueur);
                }

                lstbxJoueursEqpOrgn.DisplayMember = "NomPrenom";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //charger la liste des joueurs de l'équipe dans laquelle le joueur devra être transféré
        private void lstbxJoueursEqpTrnsfrt_Load()
        {
            try
            {
                MdlEquipeChamp slctdEqp = (MdlEquipeChamp)boxEqpTrnsfrtSelection.SelectedItem;
                JoueursServices oServices = new JoueursServices();
                List<MdlJoueurs> jrList = oServices.GetJoueursEqpList_Ssn2(slctdEqp.Id);
                foreach (MdlJoueurs joueur in jrList)
                {
                    lstbxJoueursEqpTrnsfrt.Items.Add(joueur);
                }
                lstbxJoueursEqpTrnsfrt.DisplayMember = "NomPrenom";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //(re)charger la liste d'objets joueurs dans la listbox equipe d'origine en cas de changement d'index dans la combobox eqp origine
        private void boxEqpOrgnSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstbxJoueursEqpOrgn.Items.Clear();
                lstbxJoueursEqpOrgn_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //(re)charger la liste d'objets joueurs dans la listbox equipe cible en cas de changement d'index dans la combobox eqp cible du transfert
        private void boxEqpTrnsfrtSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstbxJoueursEqpTrnsfrt.Items.Clear();
                lstbxJoueursEqpTrnsfrt_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }
    }
}
