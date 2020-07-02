using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd_UI.Calendrier;
using BackEnd_UI.Cartons;
using BackEnd_UI.GestionEquipe;
using BackEnd_UI.Joueurs;
using BackEnd_UI.Match;
using Errors;

namespace BackEnd_UI
{
    public partial class frmBE_HomePage : Form
    {
        public frmBE_HomePage()
        {
            InitializeComponent();
        }

        private void mn_VoirClassement_Click(object sender, EventArgs e)
        {
            try
            {
                frmClassement frmClas = new frmClassement();
                frmClas.MdiParent = this;
                frmClas.Show();
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

        private void mn_Results_Click(object sender, EventArgs e)
        {
            try
            {
                frmResultats frmRes = new frmResultats();
                frmRes.MdiParent = this;
                frmRes.Show();
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

        private void mn_GnrClndr_Click(object sender, EventArgs e)
        {
            try
            {
                frmCalendrier frmClndr = new frmCalendrier();
                frmClndr.MdiParent = this;
                frmClndr.Show();
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


        private void mn_InscrireJoueurs_Click(object sender, EventArgs e)
        {
            try
            {
                frmInscriptionJoueurs frmInscript = new frmInscriptionJoueurs();
                frmInscript.MdiParent = this;
                frmInscript.Show();
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

        private void mn_TransfererJoueur_Click(object sender, EventArgs e)
        {
            try
            {
                frmTransfertJoueur frmTransfert = new frmTransfertJoueur();
                frmTransfert.MdiParent = this;
                frmTransfert.Show();
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

        private void mn_HistoriqueJoueur_Click(object sender, EventArgs e)
        {
            try
            {
                frmHistoJoueur frmHisto = new frmHistoJoueur();
                frmHisto.MdiParent = this;
                frmHisto.Show();
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

        private void mn_Cartons_Click(object sender, EventArgs e)
        {
            try
            {
                frmCartons frmCart = new frmCartons();
                frmCart.MdiParent = this;
                frmCart.Show();
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
