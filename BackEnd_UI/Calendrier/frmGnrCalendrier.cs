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

namespace BackEnd_UI.Calendrier
{
    public partial class frmGnrCalendrier : Form
    {
        private List<MdlSaison> champSsnList;
        private int slctdSsn;

        public frmGnrCalendrier(List<MdlSaison> rcvdChampSsnList, int rcvdSlctdSsn)
        {
            InitializeComponent();
            champSsnList = rcvdChampSsnList;
            slctdSsn = rcvdSlctdSsn;
        }

        private void frmGnrCalendrier_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnSave.DialogResult = DialogResult.OK;
                this.btnCancel.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        private void generer_Calendrier(object sender, EventArgs e)
        {

        }
    }
}
