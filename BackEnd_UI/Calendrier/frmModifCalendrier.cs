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
        private MdlSaison oSsn;
        private MdlChampionnat oChamp;
        public frmModifCalendrier(MdlMatchClndr oMatch, MdlChampionnat oChamp, MdlSaison oSsn)
        {
            InitializeComponent();
            this.slctdMatch = oMatch;
            this.oChamp = oChamp;
            this.oSsn = oSsn;
        }

        private void frmModifCalendrier_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnSave.DialogResult = DialogResult.OK;
                lblChampionnat.Text = oChamp.NomString;
                lblSsn.Text = "Saison " + oSsn.FirstOrSecond;
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
