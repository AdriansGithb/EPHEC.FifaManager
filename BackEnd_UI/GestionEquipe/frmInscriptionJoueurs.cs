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
                boxChampSelection_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }

        }

        //charger la liste des championnats dont la date de début de première saison n'a pas commencé
        private void boxChampSelection_Load()
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

        //au changement de sélection de championnat, recharger la liste des équipes
        private void boxChampSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //récupération du championnat sélectionné
                MdlChampionnat slctdChamp = (MdlChampionnat) boxChampSelection.SelectedItem;
                //récupération de la liste des équipes inscrites au championnat
                ChampionnatsServices oServices = new ChampionnatsServices();
                List<MdlEquipeChamp> eqpList = oServices.GetEqpList_byChamp(slctdChamp.Id);
                //mise en place de la liste des équipes inscrites dans la box
                boxEqpSelection.DataSource = eqpList;
                boxEqpSelection.DisplayMember = "Nom";
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }
    }
}
