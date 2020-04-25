using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd_UI.Calendrier
{
    public partial class frmGnrCalendrier : Form
    {
        public frmGnrCalendrier()
        {
            InitializeComponent();
        }

        private void frmGnrCalendrier_Load(object sender, EventArgs e)
        {
            this.btnSave.DialogResult = DialogResult.OK;
            this.btnCancel.DialogResult = DialogResult.Cancel;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
