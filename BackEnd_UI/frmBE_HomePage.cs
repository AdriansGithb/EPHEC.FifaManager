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
                frmClassement FrmClas = new frmClassement();
                FrmClas.MdiParent = this;
                FrmClas.Show();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void mnResults_Click(object sender, EventArgs e)
        {
            try
            {
                frmResultats frmRes = new frmResultats();
                frmRes.MdiParent = this;
                frmRes.Show();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void mn_gnrClndr_Click(object sender, EventArgs e)
        {
            try
            {
                frmGnrCalendrier frmClndr = new frmGnrCalendrier();
                frmClndr.MdiParent = this;
                frmClndr.Show();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }
    }
}
