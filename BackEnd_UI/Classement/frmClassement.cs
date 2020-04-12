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
            gridClassement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void frmClassement_Load(object sender, EventArgs e)
        {
            ChampionnatsServices oService = new ChampionnatsServices();
            List<mdlChampionnat> lstChamp = new List<mdlChampionnat>();
            lstChamp = oService.GetChampionnats();
            //foreach (mdlChampionnat champ in lstChamp)
            //{
            //    boxChampSelection.Items.Add(champ.Id + " - "+ champ.Annee + " - " + champ.Nom);
            //}

            boxChampSelection.DataSource = lstChamp;
            boxChampSelection.SelectedIndex = 0;
        }

        private void boxChampSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            mdlChampionnat selChamp = new mdlChampionnat();
            selChamp = (mdlChampionnat)boxChampSelection.SelectedItem;

            ClassementServices oServices = new ClassementServices();
            List<mdlClassement> classmnt = new List<mdlClassement>();
            classmnt = oServices.GetClassement(selChamp.Id);

            gridClassement.DataSource = classmnt;
        }
    }
}
