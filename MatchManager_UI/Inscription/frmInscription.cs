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

                loadFields();
                lstbxJoueursDispo_Load();
                lstbxJoueursInscrits_Load();
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
                List<MdlJoueursParEquipe> lstJoueurs =
                    oServices.GetRegisteredTeamPlayersList_ForAMatch(slctdEqp.Id, slctdMatch.Match_ID);
                foreach (MdlJoueursParEquipe oJoueur in lstJoueurs)
                {
                    lstbxJoueursMatch.Items.Add(oJoueur);
                }
                lstbxJoueursMatch.DisplayMember = "NomPrenom";
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
    }
}
