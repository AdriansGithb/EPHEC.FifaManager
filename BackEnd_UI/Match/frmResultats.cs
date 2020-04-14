using BackEnd_BL;
using Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd_UI.Match
{
    public partial class frmResultats : Form
    {
        public frmResultats()
        {
            InitializeComponent();
            gridResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmResultats_Load(object sender, System.EventArgs e)
        {
            ChampionnatsServices oService = new ChampionnatsServices();
            List<mdlChampionnat> lstChamp = new List<mdlChampionnat>();
            lstChamp = oService.GetChampionnats();
            boxChampSelection.DataSource = lstChamp;
            boxChampSelection.SelectedIndex = 0;
        }

        private void boxChampSelection_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ResultatsServices oResServices = new ResultatsServices();
            List<mdlResultats> lstRes = oResServices.GetResultats(1);
            gridResults.DataSource = lstRes;
        }
    }
}
