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
        private List<MdlJoueurs> joueursEqpOrigineList;
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
                throw new BusinessErrors(ex.Message);
            }

        }

        //au changement de sélection de championnat, (re)charger la liste des équipes + sauvegarde liste d'origine
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
                throw new BusinessErrors(ex.Message);
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
                List<MdlJoueurs> jrList = oServices.GetJoueursEqpList_AllSsn(eqp_cochamp_id);
                //insérer chaque joueur dans la listbox
                foreach (MdlJoueurs joueur in jrList)
                    lstbxJoueursEqp.Items.Add(joueur);
                lstbxJoueursEqp.DisplayMember = "NomPrenom";
                //sauvegarde de la liste d'origine
                joueursEqpOrigineList=jrList;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //au changement de sélection d'équipe, charger les tableaux des joueurs
        private void listboxsData_Load(object sender, EventArgs e)
        {
            try
            {
                lstbxJoueursDispo_Load();
                lstbxJoueursEqp_Load();
                btnUncheckAll_Click(sender,e);
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

        //inscription de joueur dans l'équipe
        private void btnInscrire_Click(object sender, EventArgs e)
        {
            try
            {
                //si un joueur minimum est sélectionné
                if (lstbxJoueursDispo.SelectedIndices.Count > 0)
                {
                    int nbSlctdJoueurs = lstbxJoueursDispo.SelectedItems.Count;
                    int nbJoueursInscrits = lstbxJoueursEqp.Items.Count;
                    EquipesServices oServices = new EquipesServices();
                    bool conforme = oServices.SeuilMaxJoueurs_OK(nbSlctdJoueurs, nbJoueursInscrits);
                    //si le nombre de joueurs total de l'équipe ne dépasse pas le seuil max 
                    if (conforme)
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
                    //si pas conforme
                    else throw new Exception("Trop de joueurs à inscrire");
                }
                //si aucun joueur sélectionné
                else throw new Exception("Aucun joueur sélectionné pour (dés)inscription");
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

        //désinscription de joueurs de l'équipe
        private void btnDesinscrire_Click(object sender, EventArgs e)
        {
            try
            {
                //si un joueur minimum est sélectionné
                if (lstbxJoueursEqp.SelectedIndices.Count > 0)
                {
                    int nbSlctdJoueurs = lstbxJoueursEqp.SelectedItems.Count;
                    int nbJoueursEqp = lstbxJoueursEqp.Items.Count;
                    EquipesServices oServices = new EquipesServices();
                    bool conforme = oServices.SeuilMinJoueurs_OK(nbSlctdJoueurs, nbJoueursEqp);
                    //si le nombre de joueurs total de l'équipe ne dépasse pas le seuil min une fois les joueurs désinscrits 
                    if (conforme)
                    {                
                        //liste temporaire pour récupérer les objets MdlJoueurs à supprimer dans la liste des joueurs inscrits dans l'équipe
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
                    //si pas conforme
                    else throw new Exception("Trop de joueurs à désinscrire");
                }
                //si aucun joueur sélectionné
                else throw new Exception("Aucun joueur sélectionné pour (dés)inscription");
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

        //décocher tout
        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxJoueursDispo.ClearSelected();
                lstbxJoueursEqp.ClearSelected();
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

        //sauver les changements effectués
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //récupération des joueurs inscrits dans l'équipe après modifications
                List<MdlJoueurs> nwEqpList = lstbxJoueursEqpItems_ToMdlJoueursList();

                //récupération de l'équipe sélectionnée
                MdlEquipeChamp eqp = (MdlEquipeChamp) boxEqpSelection.SelectedItem;
                EquipesServices oServices = new EquipesServices();
                //envoi des objets pour sauvegarde des modifications
                oServices.SaveModifications(nwEqpList, joueursEqpOrigineList, eqp);
                MessageBox.Show("Enregistrement des modifications effectué");
                //rechargement des tableaux après sauvegarde
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
            finally
            {
                listboxsData_Load(sender, e);
            }

        }

        //vérifier si changement non sauvegardé avant de fermer
        private void frmInscriptionJoueurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //vérification d'un changement éventuel dans la liste des joueurs de l'équipe
                EquipesServices oServices = new EquipesServices();
                if (oServices.CheckIfModification(lstbxJoueursEqpItems_ToMdlJoueursList(), joueursEqpOrigineList))
                {
                    DialogResult res = MessageBox.Show(
                        "Des changements ont été effectués sans être sauvegardés. OK pour quitter sans sauver, Cancel puis Sauver pour annuler et sauver les changements. ",
                        "changements non sauvegardés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.Cancel)
                        e.Cancel = true;
                }
            }
            catch (BusinessErrors ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                throw oError;
            }
        }

        //obtenir la liste des joueurs dans lstbxJoueursEqp
        private List<MdlJoueurs> lstbxJoueursEqpItems_ToMdlJoueursList()
        {
            try
            {
                List<MdlJoueurs> tempList = new List<MdlJoueurs>();
                foreach (MdlJoueurs oJoueur in lstbxJoueursEqp.Items)
                {
                    tempList.Add(oJoueur);
                }

                return tempList;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }


    }
}
