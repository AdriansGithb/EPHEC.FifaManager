using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd_UI.Match;

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
            frmClassement FrmClas = new frmClassement();
            FrmClas.MdiParent = this;
            FrmClas.Show();
        }

        private void mnResults_Click(object sender, EventArgs e)
        {
            frmResultats frmRes = new frmResultats();
            frmRes.MdiParent = this;
            frmRes.Show();
        }
    }
}
