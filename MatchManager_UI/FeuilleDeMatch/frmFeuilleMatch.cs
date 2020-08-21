using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Errors;
using MatchManager_BL;
using Models;

namespace MatchManager_UI.FeuilleDeMatch
{
    public partial class frmFeuilleMatch : Form
    {
        private MdlMatchMM slctdMatch;
        private MdlTypeResult goodResultDom;
        private MdlTypeResult goodResultVisit;
        public frmFeuilleMatch(MdlMatchMM slctdMatch)
        {
            InitializeComponent();
            this.slctdMatch = slctdMatch;
        }

        private void frmFeuilleMatch_Load(object sender, EventArgs e)
        {
            try
            {
                lblMatch.Text = slctdMatch.NomString;
                lblNomEqpDom.Text = slctdMatch.Nom_EqpDom;
                lblNomEqpVisit.Text = slctdMatch.Nom_EqpVisit;
                boxEvents_Load();
                boxResults_Load();
                boxEquipes_Load();
                boxNbEvent_Load();
                lblScores_Load();
                boxResults_DefaultSelection();
                verifForfait_Load();
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

        //vérifier si le nb de joueurs inscrits est ok, sinon paramétrer la fenêtre et proposition de résultats
        public void verifForfait_Load()
        {
            try
            {
                EqpMatchServices oServices = new EqpMatchServices();
                bool forfaitDom, forfaitVisit = false;
                oServices.VerifierSiEquipeForfaitMatch(out forfaitDom,out forfaitVisit, slctdMatch);
                if (forfaitDom || forfaitVisit)
                {
                    gpbxEvent.Enabled = false;
                    // résultat = perdu/forfait dans les 2 équipes si les 2 = forfaits
                    if (forfaitDom && forfaitVisit)
                    {
                        boxResultDom.SelectedIndex = boxResultDom.FindStringExact("Perdu/Forfait");
                        goodResultDom = (MdlTypeResult) boxResultDom.SelectedItem;
                        boxResultVisit.SelectedIndex = boxResultVisit.FindStringExact("Perdu/Forfait");
                        goodResultVisit = (MdlTypeResult)boxResultVisit.SelectedItem;
                    }
                    // = perdu vs gagné si une seule des 2 est forfait
                    else if (forfaitDom)
                    {
                        boxResultDom.SelectedIndex = boxResultDom.FindStringExact("Perdu/Forfait");
                        goodResultDom = (MdlTypeResult)boxResultDom.SelectedItem;
                        boxResultVisit.SelectedIndex = boxResultVisit.FindStringExact("Gagné");
                        goodResultVisit = (MdlTypeResult)boxResultVisit.SelectedItem;
                    }
                    else
                    {
                        boxResultDom.SelectedIndex = boxResultDom.FindStringExact("Gagné");
                        goodResultDom = (MdlTypeResult)boxResultDom.SelectedItem;
                        boxResultVisit.SelectedIndex = boxResultVisit.FindStringExact("Perdu/Forfait");
                        goodResultVisit = (MdlTypeResult)boxResultVisit.SelectedItem;
                    }

                    MessageBox.Show(
                        "Au moins une équipe est déclarée forfait pour ce match à cause de joueurs manquants pour valider l'inscription au match. La feuille de match est donc paramétrée pour enregistrer le score par forfait.");
                }

            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //sélectionner valeurs par defaut des boxResult
        public void boxResults_DefaultSelection()
        {
            try
            {
                int scoreDom = int.Parse(lblGoalsDom.Text);
                int scoreVisit = int.Parse(lblGoalsVisit.Text);
                if (scoreDom > scoreVisit)
                {
                    boxResultDom.SelectedIndex = boxResultDom.FindStringExact("Gagné");
                    boxResultVisit.SelectedIndex = boxResultVisit.FindStringExact("Perdu");
                }
                else if (scoreDom < scoreVisit) 
                {
                    boxResultDom.SelectedIndex = boxResultDom.FindStringExact("Perdu");
                    boxResultVisit.SelectedIndex = boxResultVisit.FindStringExact("Gagné");
                }
                else
                {
                    boxResultDom.SelectedIndex = boxResultDom.FindStringExact("Nul");
                    boxResultVisit.SelectedIndex = boxResultVisit.FindStringExact("Nul");
                }
                goodResultDom = (MdlTypeResult)boxResultDom.SelectedItem;
                goodResultVisit = (MdlTypeResult)boxResultVisit.SelectedItem;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger les scores
        public void lblScores_Load()
        {
            try
            {
                int scoreDom, scoreVisit;
                MatchServices oServices = new MatchServices();
                oServices.GetMatchScore(out scoreDom, out scoreVisit, slctdMatch.Match_ID);
                lblGoalsDom.Text = scoreDom.ToString();
                lblGoalsVisit.Text = scoreVisit.ToString();
            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger la boxNbEvent
        public void boxNbEvent_Load()
        {
            try
            {
                boxNbEvent.Items.AddRange(Enumerable.Range(1, 50).Select(i => (object)i).ToArray());
                boxNbEvent.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger la liste des joueurs de l'équipe
        public void boxJoueurs_Load(object sender, EventArgs e)
        {
            try
            {
                MdlEquipeChamp slctdEqp = (MdlEquipeChamp) boxEquipes.SelectedItem;
                JoueursServices oServices = new JoueursServices();
                boxJoueurs.DataSource = oServices.GetRegisteredTeamPlayersList_ForAMatch(slctdEqp.Id,slctdMatch.Match_ID);
                boxJoueurs.DisplayMember = "NomPrenom";
            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger boxEquipes
        public void boxEquipes_Load()
        {
            try
            {
                //récupération des équipes du match
                MdlEquipeChamp eqpDom = new MdlEquipeChamp();
                eqpDom.Id = slctdMatch.EqpDom_CoChmp_ID;
                eqpDom.Nom = slctdMatch.Nom_EqpDom;
                MdlEquipeChamp eqpVisit = new MdlEquipeChamp();
                eqpVisit.Id = slctdMatch.EqpVisit_CoChmp_ID;
                eqpVisit.Nom = slctdMatch.Nom_EqpVisit;

                //insertion dans la box
                boxEquipes.Items.Add(eqpDom);
                boxEquipes.Items.Add(eqpVisit);
                boxEquipes.DisplayMember = "Nom";
                boxEquipes.SelectedIndex = 0;

            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger les boxs des types de résultats
        public void boxResults_Load()
        {
            try
            {
                MatchServices oServices = new MatchServices();
                 
                boxResultDom.DataSource = oServices.GetResultTypes(); 
                boxResultDom.DisplayMember = "Libelle";

                boxResultVisit.DataSource = oServices.GetResultTypes();
                boxResultVisit.DisplayMember = "Libelle";
            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //charger la box des types d'événements
        public void boxEvents_Load()
        {
            try
            {
                MatchServices oServices = new MatchServices();
                boxEvent.DataSource = oServices.GetEventTypes();
                boxEvent.DisplayMember = "Libelle";
            }
            catch (BusinessErrors )
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //sauver l'événement encodé
        private void btnEventSave_Click(object sender, EventArgs e)
        {
            try
            {
                MdlTypeEvent slctdEvent = (MdlTypeEvent) boxEvent.SelectedItem;
                MdlEquipeChamp slctdEquipe = (MdlEquipeChamp) boxEquipes.SelectedItem;
                MdlJoueursParEquipe slctdJoueur = (MdlJoueursParEquipe) boxJoueurs.SelectedItem;
                int nbEvent = (int) boxNbEvent.SelectedItem;

                if (slctdEvent.Libelle.Equals("Carton jaune")|| slctdEvent.Libelle.Equals("Carton rouge"))
                {
                    frmSuspensions oFrmSuspensions = new frmSuspensions(slctdMatch ,slctdEvent,slctdJoueur, nbEvent );
                    oFrmSuspensions.ShowDialog();
                }
                else if(slctdEvent.Libelle.Contains("Goal"))
                {
                    EventsServices oServices = new EventsServices();
                    oServices.SaveGoalEvents(nbEvent, slctdJoueur, slctdMatch, slctdEvent);
                    MessageBox.Show("Goal(s) sauvegardé(s)");
                    lblScores_Load();
                    boxResults_DefaultSelection();
                }
                else throw new BusinessErrors("type event non reconnu");
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

        //sauver le résultat
        private void btnResultSave_Click(object sender, EventArgs e)
        {
            try
            {
                MdlTypeResult slctdResDom = (MdlTypeResult) boxResultDom.SelectedItem;
                MdlTypeResult slctdResVisit = (MdlTypeResult)boxResultVisit.SelectedItem;
                bool save = true;

                //si un des 2 résultats à enregistrer est de type "pas joué/encodé"
                if (slctdResVisit.Libelle.Contains("Pas joué") || slctdResDom.Libelle.Contains("Pas joué"))
                {
                    throw new BusinessErrors("Enregistrement résultat non encodé");
                }
                //si un des deux résultats sélectionné n'est pas le même que celui qui devrait être sélectionné
                else if (!slctdResDom.Libelle.Equals(goodResultDom.Libelle) ||
                    !slctdResVisit.Libelle.Equals(goodResultVisit.Libelle))
                    {
                        DialogResult res = MessageBox.Show($"Vous allez sauvegarder des résultats qui ne correspondent pas au score. Le bon résultat devrait être : {goodResultDom.Libelle} - {goodResultVisit.Libelle}. Cliquez sur OK pour sauver malgré tout, ou sur ANNULER pour revenir dans la feuille de match.", "Resultats manuels erronés", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.Cancel)
                            save = false;
                    }
                
                //si sauvegarde possible (save = true)
                if (save)
                {
                    MatchServices oServices = new MatchServices();
                    oServices.SetMatchResults(slctdMatch.Match_ID, slctdResDom.Id, slctdResVisit.Id, slctdMatch.LastUpdate);
                    MessageBox.Show("Feuille de match enregistrée et clôturée");
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
    }
}
