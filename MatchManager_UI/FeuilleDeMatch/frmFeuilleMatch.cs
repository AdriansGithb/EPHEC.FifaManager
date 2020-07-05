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
            catch (BusinessErrors ex)
            {
                throw ex;
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
            catch (BusinessErrors ex)
            {
                throw ex;
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
            catch (BusinessErrors ex)
            {
                throw ex;
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
            catch (BusinessErrors ex)
            {
                throw ex;
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

    }
}
