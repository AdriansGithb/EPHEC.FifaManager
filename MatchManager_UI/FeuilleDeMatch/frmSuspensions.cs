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
using MatchManager_BL;

namespace MatchManager_UI.FeuilleDeMatch
{
    public partial class frmSuspensions : Form
    {
        private MdlMatchMM matchOrigineSanction;
        private MdlTypeEvent slctdEvent ;
        private MdlEquipeChamp slctdEquipeChamp ;
        private MdlJoueursParEquipe slctdJoueur ;
        private int nbEvent ;
        private int nbSuspensions;

        public frmSuspensions(MdlMatchMM matchOrigineSanction,MdlTypeEvent slctdEvent, MdlEquipeChamp slctdEquipeChamp, MdlJoueursParEquipe slctdJoueur, int nbEvent )
        {
            try
            {
                InitializeComponent();
                this.matchOrigineSanction = matchOrigineSanction;
                this.slctdEvent = slctdEvent;
                this.slctdEquipeChamp = slctdEquipeChamp;
                this.slctdJoueur = slctdJoueur;
                this.nbEvent = nbEvent;
                this.nbSuspensions = nbEvent * slctdEvent.Nb_Jours_Suspension;
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void frmSuspensions_Load(object sender, EventArgs e)
        {
            try
            {
                lbljoueur.Text = slctdJoueur.NomPrenom;
                lblCarton.Text = $"{nbEvent} * {slctdEvent.Libelle}";
                lblNbMatchTotal.Text = nbSuspensions.ToString();
                lblNbMatchsRestant.Text = nbSuspensions.ToString();
                lstbxMatchs_Load();                
                checkIfNextMatchRule();

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

        //remplir la liste de matchs
        public void lstbxMatchs_Load()
        {
            try
            {
                MatchServices oServices = new MatchServices();
                List<MdlMatchMM> matchList =
                    oServices.GetMatchsRestantsList(slctdJoueur.CEqp_Id,(DateTime) matchOrigineSanction.Date );
                foreach (MdlMatchMM oMatch in matchList)
                {
                    lstbxMatchsRestant.Items.Add(oMatch);
                }
                lstbxMatchsRestant.DisplayMember = "NomString";
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

        //vérifier si on peut choisir le match ou si ce sont obligatoirement les matchs suivants
        private void checkIfNextMatchRule()
        {
            try
            {
                //si la suspension est obligatoirement liée aux matchs suivants, autosélectionner et désactiver la permission de choix
                if (slctdEvent.Susp_Next_Match)
                {
                    lstbxMatchsRestant.Enabled = false;
                    for (int i = 0; i < nbSuspensions && i < lstbxMatchsRestant.Items.Count; i++)
                    {
                        lstbxMatchsRestant.SelectedIndices.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //màj le label du nb de matchs restants à sélectionner lors d'un changement d'index sélectionné dans la listbox
        private void lstbxMatchsRestant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int nbMatchsStillToSelect = nbSuspensions - lstbxMatchsRestant.SelectedItems.Count;
                lblNbMatchsRestant.Text = nbMatchsStillToSelect.ToString();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //sauver la sélection de matchs de suspensions
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //si carton jaune, vérification du nb de matchs sélectionnés
                //si carton rouge, la sélection des matchs de suspension next match est automatisée, le nb ne doit pas être vérifié
                if (slctdEvent.Susp_Next_Match == false && int.Parse(lblNbMatchsRestant.Text) != 0 && lstbxMatchsRestant.SelectedItems.Count < lstbxMatchsRestant.Items.Count)
                {
                    throw new BusinessErrors("Nombre de matchs de suspension sélectionnés erroné");
                }
                else
                {
                    //sauver les cartons + les suspensions liées
                    EventsServices oServices = new EventsServices();
                    List<MdlMatchMM> suspList = new List<MdlMatchMM>();
                    foreach (MdlMatchMM oMatch in lstbxMatchsRestant.SelectedItems)
                    {
                        suspList.Add(oMatch);
                    }
                    oServices.SaveCardEvents(nbEvent, slctdJoueur, matchOrigineSanction, slctdEvent, suspList);
                    MessageBox.Show("Enregistrement effectués");
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
