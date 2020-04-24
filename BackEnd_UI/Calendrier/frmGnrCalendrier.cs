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
            this.button1.DialogResult = DialogResult.OK;
            this.button2.DialogResult = DialogResult.Cancel;

        }
    }
}
