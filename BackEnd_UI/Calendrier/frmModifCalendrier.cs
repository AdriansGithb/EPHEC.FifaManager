using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace BackEnd_UI
{
    public partial class frmModifCalendrier : Form
    {
        private MdlMatchClndr slctdMatch;
        public frmModifCalendrier(MdlMatchClndr oMatch, string oChamp, string oSsn)
        {
            InitializeComponent();
            slctdMatch = oMatch;
            lblChampionnat.Text = oChamp;
            lblSsn.Text = oSsn;
        }

        private void frmModifCalendrier_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnSave.DialogResult = DialogResult.OK;
                lblNomEqpDom.Text = slctdMatch.Nom_EqpDom;
                lblNomEqpVst.Text = slctdMatch.Nom_EqpVisit;
                if (slctdMatch.Date != null)
                    lblPrevDate.Text = ((DateTime) slctdMatch.Date).ToString("D", new CultureInfo("fr-FR"));
            }
            catch (Exception ex)
            {

            }
        }
    }
}
