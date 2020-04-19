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
            List<mdlChampionnat> lstChamp = new List<mdlChampionnat>();
            lstChamp = oService.GetChampionnats();
            boxChampSelection.DataSource = lstChamp;
            boxChampSelection.SelectedIndex = 0;
        }

        private void boxChampSelection_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //vérification du radiobutton sélectionné pour connaître la saison à afficher
            int ssn;
            if (rdbtnSeason1.Checked == true)
                ssn = 1;
                else if (rdbtnSeason2.Checked == true)
                    ssn = 2;
                    else ssn = 12;
            //récupération de l'ID championnat sélectionné
            mdlChampionnat oChamp = new mdlChampionnat();
            oChamp = (mdlChampionnat)boxChampSelection.SelectedItem;
            int champId = oChamp.Id;
            //envoi de la requête vers la BL pour remplir le datagridview en fonction du championnat et de la/les saison(s)
            ResultatsServices oResServices = new ResultatsServices();
            List<mdlResultats> lstRes = oResServices.GetResultats(champId,ssn);
            gridResults.DataSource = lstRes;
        }
    }
}
