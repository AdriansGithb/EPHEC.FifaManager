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
