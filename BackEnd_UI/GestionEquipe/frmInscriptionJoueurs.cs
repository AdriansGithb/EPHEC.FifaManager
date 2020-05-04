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

        //au changement de sélection de championnat, (re)charger la liste des équipes
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
                lstbxJoueursDispo.Items.Clear();
                JoueursServices oServices = new JoueursServices();
                int champ_id = ((MdlChampionnat) boxChampSelection.SelectedItem).Id;
                List<MdlJoueurs> jrList = oServices.GetJoueursDispo_byChamp(champ_id);
                //insérer chaque joueur dans la listbox
                foreach (MdlJoueurs joueur in jrList)
                    lstbxJoueursDispo.Items.Add(joueur);
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
                lstbxJoueursEqp.Items.Clear();
                JoueursServices oServices = new JoueursServices();
                int eqp_cochamp_id = ((MdlEquipeChamp)boxEqpSelection.SelectedItem).Id;
                List<MdlJoueurs> jrList = oServices.GetJoueursEqpList(eqp_cochamp_id);
                //insérer chaque joueur dans la listbox
                foreach (MdlJoueurs joueur in jrList)
                    lstbxJoueursEqp.Items.Add(joueur);
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
            try
            {
                lstbxJoueursDispo_Load();
                lstbxJoueursEqp_Load();
                btnUncheckAll_Click(sender,e);
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            try
            {
                //si un joueur minimum est sélectionné
                if (lstbxJoueursDispo.SelectedIndices.Count > 0)
                {
                    //liste temporaire pour récupérer les objets MdlJoueurs à supprimer dans la liste des joueurs dispos
                    List<MdlJoueurs> tmpList = new List<MdlJoueurs>();
                    foreach (MdlJoueurs oJoueur in lstbxJoueursDispo.SelectedItems)
                    {
                        lstbxJoueursEqp.Items.Add(oJoueur);
                        tmpList.Add(oJoueur);
                    }
                    //suppression des joueurs de la liste des joueurs dispos
                    foreach (MdlJoueurs oJoueur in tmpList)
                    {
                        lstbxJoueursDispo.Items.Remove(oJoueur);
                    }
                }
                //sinon
                else throw new Exception("Aucun joueur sélectionné pour (dés)inscription");
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void btnDesinscrire_Click(object sender, EventArgs e)
        {
            try
            {
                //liste temporaire pour récupérer les objets MdlJoueurs à supprimer dans la liste des joueurs inscrits dans l'équipe
                if (lstbxJoueursEqp.SelectedIndices.Count > 0)
                {
                    List<MdlJoueurs> tmpList = new List<MdlJoueurs>();
                    foreach (MdlJoueurs oJoueur in lstbxJoueursEqp.SelectedItems)
                    {
                        lstbxJoueursDispo.Items.Add(oJoueur);
                        tmpList.Add(oJoueur);
                    }
                    //suppression des joueurs de la liste des joueurs inscrits dans l'équipe
                    foreach (MdlJoueurs oJoueur in tmpList)
                    {
                        lstbxJoueursEqp.Items.Remove(oJoueur);
                    }
                }
                else throw new Exception("Aucun joueur sélectionné pour (dés)inscription");
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxJoueursDispo.ClearSelected();
                lstbxJoueursEqp.ClearSelected();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }
    }
}
