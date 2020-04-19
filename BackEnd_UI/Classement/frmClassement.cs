using BackEnd_BL;
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

namespace BackEnd_UI
{
    public partial class frmClassement : Form
    {
        public frmClassement()
        {
            InitializeComponent();
            /* ajout des méthodes suivantes dans le initialize component :
                * this.gridClassement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    *permet aux données de remplir le tab
             */
        }

        //chargement de la page classement : liste de championnats chargée dans la combobox, 1er champ sélectionné et chargé par défaut
        private void frmClassement_Load(object sender, EventArgs e)
        {
            ChampionnatsServices oService = new ChampionnatsServices();
            List<MdlChampionnat> lstChamp = new List<MdlChampionnat>();
            lstChamp = oService.GetChampionnats();
            boxChampSelection.DataSource = lstChamp;
            boxChampSelection.SelectedIndex = 0;
        }

        //changement du tableau de classement lorsque l'on change de championnat sélectionné
        private void boxChampSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            MdlChampionnat selChamp = new MdlChampionnat();
            selChamp = (MdlChampionnat)boxChampSelection.SelectedItem;

            ClassementServices oServices = new ClassementServices();
            List<MdlClassement> classmnt = new List<MdlClassement>();
            classmnt = oServices.GetClassement(selChamp.Id);

            gridClassement.DataSource = classmnt;
            gridClassement.Columns[0].HeaderText = "Position";
            gridClassement.Columns[1].HeaderText = "Points";
            gridClassement.Columns[2].HeaderText = "Equipe";
            gridClassement.Columns[3].HeaderText = "Equipe ID";

        }
    }
}
