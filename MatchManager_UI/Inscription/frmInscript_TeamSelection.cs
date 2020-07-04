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
using Models;

namespace MatchManager_UI.Inscription
{
    public partial class frmInscript_TeamSelection : Form
    {
        private MdlMatchMM slctdMatch;
        public frmInscript_TeamSelection(MdlMatchMM slctdMatch)
        {
            InitializeComponent();
            this.slctdMatch = slctdMatch;
            lblMatch.Text = slctdMatch.NomString;
            btnEqpDom.Text = slctdMatch.Nom_EqpDom;
            btnEqpVisit.Text = slctdMatch.Nom_EqpVisit;
        }

        //sélection de l'équipe domicile
        private void btnEqpDom_Click(object sender, EventArgs e)
        {
            try
            {
                bool eqpDom = true;
                frmInscription oFrmInscription = new frmInscription(this.slctdMatch, eqpDom);
                oFrmInscription.ShowDialog();
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

        //sélection de l'équipe visiteuse
        private void btnEqpVisit_Click(object sender, EventArgs e)
        {
            try
            {
                bool eqpDom = false;
                frmInscription oFrmInscription = new frmInscription(this.slctdMatch, eqpDom);
                oFrmInscription.ShowDialog();
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
