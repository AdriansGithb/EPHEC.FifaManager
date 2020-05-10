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
        }

        private void frmHistoJoueur_Load(object sender, EventArgs e)
        {
            try
            {
                lstbxJoueurs_Load();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

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
    }
}
