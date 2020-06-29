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
using Models;

namespace MatchManager_UI
{
    public partial class frmMM_HomePage : Form
    {
        public frmMM_HomePage()
        {
            try
            {
                InitializeComponent();
                //remplir la box de sélection de championnat
                Load_ChampList();
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

        //remplir la combobox de sélection de championnat
        public void Load_ChampList()
        {
            try
            {
                ChampionnatsServices oServices = new ChampionnatsServices();
                //remplissage de la liste par la liste des championnats
                boxChampSelection.DataSource = oServices.GetAllChampionnats();
                boxChampSelection.DisplayMember = "NomString";
                boxChampSelection.SelectedIndex = 0;
            }
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //remplir la combobox de sélection d'un match
        public void Load_MatchList(object sender, EventArgs e)
        {
            try
            {
                //récupérer l'id du championnat sélectionné
                MdlChampionnat slctdChamp = (MdlChampionnat) boxChampSelection.SelectedItem;
                int slctdSsn = checkRdbtnSelection();
                //récupérer la liste de la sélection
                ChampionnatsServices oServices = new ChampionnatsServices();
                boxMatchSelection.DataSource = oServices.GetMatchList(slctdChamp.Id, slctdSsn);
                boxMatchSelection.DisplayMember = "NomString";
                boxMatchSelection.SelectedItem = 0;
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

        //savoir quel radiobutton est sélectionné
        private int checkRdbtnSelection()
        {
            try
            {
                int slctdBtn;
                //vérification du radiobutton sélectionné pour connaître la saison à afficher
                if (rdBtn_Ssn1.Checked == true)
                    slctdBtn = 1;
                else if (rdBtn_Ssn2.Checked == true)
                    slctdBtn = 2;
                else slctdBtn = 12;
                return slctdBtn;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }

        }


    }
}
