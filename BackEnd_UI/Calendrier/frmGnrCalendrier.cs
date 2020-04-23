using BackEnd_BL;
using Errors;
using Models;
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
            try
            {
                //chargement de la liste des championnats
                ChampionnatsServices oService = new ChampionnatsServices();
                List<MdlChampionnat> lstChamp = new List<MdlChampionnat>();
                lstChamp = oService.GetChampionnats();
                boxChampSelection.DataSource = lstChamp;
                boxChampSelection.DisplayMember = "NomString";
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }
    }
}
