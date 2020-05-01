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
using BackEnd_BL;
using Errors;
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
                DateTimePicker_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //initialisation du datetimepicker
        private void DateTimePicker_Load()
        {
            try
            {
                //sélection de la date de match si il y en a déjà une
                if (slctdMatch.Date != null)
                {
                    lblPrevDate.Text = ((DateTime)slctdMatch.Date).ToString("D", new CultureInfo("fr-FR"));
                    dtTmPckrMatch.Value = (DateTime)slctdMatch.Date;
                }
                else dtTmPckrMatch.Value = oSsn.Debut;
                //baliser la sélection de date entre le début et la fin de la saison
                CalendrierServices oServices = new CalendrierServices();
                dtTmPckrMatch.MinDate = oSsn.Debut;
                dtTmPckrMatch.MaxDate = oServices.GetEndSsnDate(oSsn.Debut);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
