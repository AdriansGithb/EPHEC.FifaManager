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
        public static MdlResultats ResAModifier;
        public frmResultats()
        {
            InitializeComponent();
            /* ajout des méthodes suivantes dans le initialize component :
                * this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    *permet aux données de remplir le tab
                *
             */
        }

        private void frmResultats_Load(object sender, System.EventArgs e)
        {

            //chargement de la liste des championnats
            ChampionnatsServices oService = new ChampionnatsServices();
            List<MdlChampionnat> lstChamp = new List<MdlChampionnat>();
            lstChamp = oService.GetChampionnats();
            boxChampSelection.DataSource = lstChamp;
        }

        private void gridResults_LoadSelection(object sender, System.EventArgs e)
        {
            //vérification du radiobutton sélectionné pour connaître la saison à afficher
            int ssn;
            if (rdbtnSeason1.Checked == true)
                ssn = 1;
                else if (rdbtnSeason2.Checked == true)
                    ssn = 2;
                    else ssn = 12;
            //récupération de l'ID championnat sélectionné
            MdlChampionnat oChamp = new MdlChampionnat();
            oChamp = (MdlChampionnat)boxChampSelection.SelectedItem;
            int champId = oChamp.Id;
            //envoi de la requête vers la BL pour remplir le datagridview en fonction du championnat et de la/les saison(s)
            ResultatsServices oResServices = new ResultatsServices();
            List<MdlResultats> lstRes = oResServices.GetResultats(champId,ssn);
            gridResults.DataSource = lstRes;
        }

        private void gridResults_DoubleClick(object sender, System.EventArgs e)
        {
            ResAModifier = (MdlResultats)gridResults.CurrentRow.DataBoundItem;
            frmModifResult oFrmModifResult = new frmModifResult();
            oFrmModifResult.MdiParent = this.MdiParent;
            oFrmModifResult.Show();
        }
    }
}
