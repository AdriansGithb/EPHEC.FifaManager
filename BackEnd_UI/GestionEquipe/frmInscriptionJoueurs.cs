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

namespace BackEnd_UI.GestionEquipe
{
    public partial class frmInscriptionJoueurs : Form
    {
        public frmInscriptionJoueurs()
        {
            InitializeComponent();
        }

        private void frmInscriptionJoueurs_Load(object sender, EventArgs e)
        {
            try
            {
                bxChampSelection_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }

        }

        //charger la liste des championnats dont la date de début de première saison n'a pas commencé
        private void bxChampSelection_Load()
        {
            try
            {
                //chargement de la liste des championnats non débutés
                ChampionnatsServices oService = new ChampionnatsServices();
                List<MdlChampionnat> lstChamp = new List<MdlChampionnat>();
                lstChamp = oService.GetNotStartedChampionnats();
                boxChampSelection.DataSource = lstChamp;
                boxChampSelection.DisplayMember = "NomString";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
