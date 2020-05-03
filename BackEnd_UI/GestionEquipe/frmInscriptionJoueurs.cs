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

namespace BackEnd_UI.GestionEquipe
{
    public partial class frmInscriptionJoueurs : Form
    {
        private bool change;
        public frmInscriptionJoueurs()
        {
            InitializeComponent();
        }

        private void frmInscriptionJoueurs_Load(object sender, EventArgs e)
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

        //charger la liste des championnats dont la date de début de première saison n'a pas commencé
        private void boxChampSelection_Load()
        {
            try
            {
                //chargement de la liste des championnats non débutés
                ChampionnatsServices oService = new ChampionnatsServices();
                List<MdlChampionnat> lstChamp = new List<MdlChampionnat>();
                lstChamp = oService.GetNotStartedChampionnats();
                boxChampSelection.DataSource = lstChamp;
                boxChampSelection.DisplayMember = "NomString";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //au changement de sélection de championnat, recharger la liste des équipes
        private void boxChampSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //récupération du championnat sélectionné
                MdlChampionnat slctdChamp = (MdlChampionnat) boxChampSelection.SelectedItem;
                //récupération de la liste des équipes inscrites au championnat
                ChampionnatsServices oServices = new ChampionnatsServices();
                List<MdlEquipeChamp> eqpList = oServices.GetEqpList_byChamp(slctdChamp.Id);
                //mise en place de la liste des équipes inscrites dans la box
                boxEqpSelection.DataSource = eqpList;
                boxEqpSelection.DisplayMember = "Nom";
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //chargement de la liste des joueurs disponibles (non inscrits dans une équipe)
        private void lstbxJoueursDispo_Load()
        {
            try
            {
                JoueursServices oServices = new JoueursServices();
                int champ_id = ((MdlChampionnat) boxChampSelection.SelectedItem).Id;
                lstbxJoueursDispo.DataSource = oServices.GetJoueursDispo_byChamp(champ_id);
                lstbxJoueursDispo.DisplayMember = "NomPrenom";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //chargement de la liste des joueurs de l'équipe (inscrits dans l'équipe sélectionnée)
        private void lstbxJoueursEqp_Load()
        {
            try
            {
                JoueursServices oServices = new JoueursServices();
                int eqp_cochamp_id = ((MdlEquipeChamp)boxEqpSelection.SelectedItem).Id;
                lstbxJoueursEqp.DataSource = oServices.GetJoueursEqpList(eqp_cochamp_id);
                lstbxJoueursEqp.DisplayMember = "NomPrenom";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //au changement de sélection d'équipe, charger les tableaux des joueurs
        private void boxEqpSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxJoueursDispo_Load();
            lstbxJoueursDispo.SelectedIndex = -1;
            lstbxJoueursEqp_Load();
            lstbxJoueursEqp.SelectedIndex = -1;
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            change = true;
        }

        private void btnDesinscrire_Click(object sender, EventArgs e)
        {
            change = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            change = false;
        }
    }
}
