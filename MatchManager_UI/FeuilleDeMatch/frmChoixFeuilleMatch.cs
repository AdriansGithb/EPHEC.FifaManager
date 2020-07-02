using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Errors;
using MatchManager_BL;

namespace MatchManager_UI.FeuilleDeMatch
{
    public partial class frmChoixFeuilleMatch : Form
    {
        public frmChoixFeuilleMatch()
        {
            InitializeComponent();
        }

        private void frmChoixFeuilleMatch_Load(object sender, EventArgs e)
        {
            try
            {
                //remplir le nom du championnat de l'année
                ChampionnatsServices oChmpServ = new ChampionnatsServices();
                lblCurrntChamp.Text = (oChmpServ.GetChampOfThisYear()).NomString;

                //remplir la liste des matchs du jour
                MatchServices oMchServ = new MatchServices();
                boxMatchSelection.DataSource = oMchServ.GetMatchsOfTheDay();
                boxMatchSelection.DisplayMember = "NomString";
                boxMatchSelection.SelectedItem = 0;
                //activer/désactiver le bouton inscrire si la liste de matchs est vide
                if (boxMatchSelection.Items.Count > 0)
                    btnSelect.Enabled = true;
            }
            catch (BusinessErrors ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }
    }
}
