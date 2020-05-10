using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd_BL;
using Errors;
using Models;

namespace BackEnd_UI.Joueurs
{
    public partial class frmHistoJoueur : Form
    {
        public frmHistoJoueur()
        {
            InitializeComponent();
            datagridHisto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmHistoJoueur_Load(object sender, EventArgs e)
        {
            try
            {
                lstbxJoueurs_Load();
                lstbxJoueurs.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //chargement de la listbox avec la liste des joueurs
        private void lstbxJoueurs_Load()
        {
            try
            {
                JoueursServices oServices = new JoueursServices();
                List<MdlJoueurs> jrList = oServices.GetAllJoueursList();
                foreach (MdlJoueurs joueur in jrList)
                {
                    lstbxJoueurs.Items.Add(joueur);
                }
                lstbxJoueurs.DisplayMember = "NomPrenom";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //au changement de la sélection d'un joueur, charger le datagrid et le label du joueur sélectionné
        private void lstbxJoueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MdlJoueurs slctdJoueur = (MdlJoueurs) lstbxJoueurs.SelectedItem;
                lblSlctdJoueur_Load(slctdJoueur);
                datagridHisto_Load(slctdJoueur);
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //charger le datagrid en fonction du joueur sélectionné
        private void datagridHisto_Load(MdlJoueurs slctdJoueur)
        {
            try
            {
                JoueursServices oServices = new JoueursServices();
                datagridHisto.DataSource = oServices.GetHistorique_Joueur(slctdJoueur);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //charger le label en fonction du joueur sélectionné
        private void lblSlctdJoueur_Load(MdlJoueurs slctdJoueur)
        {
            try
            {
                lblSlctdJoueur.Text = $"{slctdJoueur.NomPrenom}  - {slctdJoueur.Id} -";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
