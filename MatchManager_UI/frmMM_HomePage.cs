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

namespace MatchManager_UI
{
    public partial class frmMM_HomePage : Form
    {
        public frmMM_HomePage()
        {
            InitializeComponent();
        }

        private void inscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmInscriptions frmInscript = new frmInscriptions();
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
    }
}
