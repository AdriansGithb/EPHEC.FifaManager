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
using MatchManager_BL;
using Models;

namespace MatchManager_UI.Inscription
{
    public partial class frmInscription : Form
    {
        private MdlMatchMM slctdMatch;
        private MdlEquipeChamp slctdEqp;
        private List<MdlJoueursParEquipe> eqpMatchOrigine;

        //réception du match sélectionné, et du choix de l'équipe : 
            // eqpDom = true si équipe domicile sélectionnée, false si eqp visiteuse sélectionnée
        public frmInscription(MdlMatchMM slctdMatch, bool eqpDom)
        {
            try
            {
                InitializeComponent();
                this.slctdMatch = slctdMatch;
                switch (eqpDom)
                {
                    case true:
                    {
                        this.slctdEqp = new MdlEquipeChamp();
                        this.slctdEqp.Id = slctdMatch.EqpDom_CoChmp_ID;
                        this.slctdEqp.Nom = slctdMatch.Nom_EqpDom;
                    }
                        break;
                    case false:
                    {
                        this.slctdEqp = new MdlEquipeChamp();
                        this.slctdEqp.Id = slctdMatch.EqpVisit_CoChmp_ID;
                        this.slctdEqp.Nom = slctdMatch.Nom_EqpVisit;
                    }
                        break;
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
        private void frmInscription_Load(object sender, EventArgs e)
        {
            try
            {
                loadFields();
                loadListboxesData();
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

        //charger les labels de la form
        public void loadFields()
        {
            try
            {
                this.lblMatch.Text = slctdMatch.NomString;
                this.lblEqp.Text = slctdEqp.Nom;
            }
            catch(Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger les datas des listboxs
        public void loadListboxesData()
        {
            try
            {
                lstbxJoueursInscrits_Load();
                lstbxJoueursDispo_Load();
            }
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger la listbox des joueurs disponibles (pouvant être inscrits)
        public void lstbxJoueursDispo_Load()
        {
            try
            {
                lstbxJoueursDispo.Items.Clear();
                JoueursServices oServices = new JoueursServices();
                List<MdlJoueursParEquipe> lstJoueurs =
                    oServices.GetAvailableTeamPlayersList_ForAMatch(slctdEqp.Id, slctdMatch.Match_ID);
                foreach (MdlJoueursParEquipe oJoueur in lstJoueurs)
                {
                    lstbxJoueursDispo.Items.Add(oJoueur);
                }
                lstbxJoueursDispo.DisplayMember = "NomPrenom";
            }
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger la listbox des joueurs déjà inscrits au match 
        public void lstbxJoueursInscrits_Load()
        {
            try
            {
                lstbxJoueursMatch.Items.Clear();
                JoueursServices oServices = new JoueursServices();
                List<MdlJoueursParEquipe> lstJoueursInscrits =
                    oServices.GetRegisteredTeamPlayersList_ForAMatch(slctdEqp.Id, slctdMatch.Match_ID);
                foreach (MdlJoueursParEquipe oJoueur in lstJoueursInscrits)
                {
                    lstbxJoueursMatch.Items.Add(oJoueur);
                }
                lstbxJoueursMatch.DisplayMember = "NomPrenom";
                eqpMatchOrigine = lstJoueursInscrits;
            }
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
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
                    int nbJoueursInscrits = lstbxJoueursMatch.Items.Count;
                    EqpMatchServices oServices = new EqpMatchServices();
                    bool conforme = oServices.SeuilMaxJoueurs_OK(nbSlctdJoueurs, nbJoueursInscrits);
                    //si le nombre de joueurs total de l'équipe ne dépasse pas le seuil max 
                    if (conforme)
                    {
                        //liste temporaire pour récupérer les objets MdlJoueurs à supprimer dans la liste des joueurs dispos
                        List<MdlJoueursParEquipe> tmpList = new List<MdlJoueursParEquipe>();
                        foreach (MdlJoueursParEquipe oJoueur in lstbxJoueursDispo.SelectedItems)
                        {
                            lstbxJoueursMatch.Items.Add(oJoueur);
                            tmpList.Add(oJoueur);
                        }

                        //suppression des joueurs de la liste des joueurs dispos
                        foreach (MdlJoueursParEquipe oJoueur in tmpList)
                        {
                            lstbxJoueursDispo.Items.Remove(oJoueur);
                        }
                    }
                    //si pas conforme
                    else throw new BusinessErrors("Trop de joueurs à inscrire au match");
                }
                //si aucun joueur sélectionné
                else throw new BusinessErrors("Aucun joueur sélectionné pour (dés)inscription");
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
                if (lstbxJoueursMatch.SelectedIndices.Count > 0)
                {
                    int nbSlctdJoueurs = lstbxJoueursMatch.SelectedItems.Count;
                    int nbJoueursInscrits = lstbxJoueursMatch.Items.Count;
                    EqpMatchServices oServices = new EqpMatchServices();
                    bool conforme = oServices.SeuilMinJoueurs_OK(nbSlctdJoueurs, nbJoueursInscrits);
                    //si le nombre de joueurs total de joueurs inscrits n'est pas inférieur au seuil min requis d'inscription 
                    if (conforme)
                    {
                        //liste temporaire pour récupérer les objets MdlJoueurs à supprimer dans la liste des joueurs inscrits au match
                        List<MdlJoueursParEquipe> tmpList = new List<MdlJoueursParEquipe>();
                        foreach (MdlJoueursParEquipe oJoueur in lstbxJoueursMatch.SelectedItems)
                        {
                            lstbxJoueursDispo.Items.Add(oJoueur);
                            tmpList.Add(oJoueur);
                        }

                        //suppression des joueurs de la liste des joueurs inscrits dans l'équipe
                        foreach (MdlJoueursParEquipe oJoueur in tmpList)
                        {
                            lstbxJoueursMatch.Items.Remove(oJoueur);
                        }
                    }
                    //si pas conforme
                    else throw new BusinessErrors("Trop de joueurs à désinscrire");
                }
                //si aucun joueur sélectionné
                else throw new BusinessErrors("Aucun joueur sélectionné pour (dés)inscription");
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

        //désélectionner tout
        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxJoueursDispo.ClearSelected();
                lstbxJoueursMatch.ClearSelected();
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

        //annuler les modifications en cours
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                btnUncheckAll_Click(sender, e);
                loadListboxesData();
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
                bool save = true;
                EqpMatchServices oServices = new EqpMatchServices();
                //si le nb de joueurs inscrits au match est inférieur au seuil min requis, informer l'utilisateur du risque de perte par forfait
                //et demander s'il souhaite sauver malgré tout
                    //ce cas est possible si, par exemple, des joueurs ont été sanctionnés
                if (oServices.SeuilMinJoueurs_OK(lstbxJoueursMatch.Items.Count) == false)
                {
                    DialogResult res =MessageBox.Show(
                            "Attention, l'équipe a moins de 5 joueurs inscrits et risque donc de perdre le match par forfait. Cliquer sur OK pour sauver malgré tout, ou sur CANCEL pour continuer les inscriptions.",
                            "Seuil minimum de joueurs non atteint", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2);
                    if (res == DialogResult.Cancel)
                        save = false;
                }

                //si l'utilisateur a confirmé la sauvegarde ou si le seuil min. requis est atteint
                if (save)
                {
                    //récupération des joueurs inscrits dans l'équipe après modifications
                    List<MdlJoueursParEquipe> nwEqpList = lstbxJoueursMatchItems_ToMdlJoueursList();

                    //envoi des objets pour sauvegarde des modifications
                    oServices.SaveModifications(nwEqpList, eqpMatchOrigine, slctdMatch);
                    MessageBox.Show("Enregistrement des modifications effectué");
                    this.DialogResult = DialogResult.OK;
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

        //obtenir la liste des joueurs dans lstbxJoueursMatch
        private List<MdlJoueursParEquipe> lstbxJoueursMatchItems_ToMdlJoueursList()
        {
            try
            {
                List<MdlJoueursParEquipe> tempList = new List<MdlJoueursParEquipe>();
                foreach (MdlJoueursParEquipe oJoueur in lstbxJoueursMatch.Items)
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

        private void frmInscription_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //vérification d'un changement éventuel dans la liste des joueurs inscrits au match
                EqpMatchServices oServices = new EqpMatchServices();
                if (this.DialogResult!=DialogResult.OK && oServices.CheckIfModification(lstbxJoueursMatchItems_ToMdlJoueursList(), eqpMatchOrigine))
                {
                    DialogResult res = MessageBox.Show(
                        "Des changements ont été effectués sans être sauvegardés. OK pour quitter sans sauver, ANNULER puis Sauver pour annuler et sauver les changements. ",
                        "Changements non sauvegardés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                MessageBox.Show(oError.Message);
            }
        }
    }
}
