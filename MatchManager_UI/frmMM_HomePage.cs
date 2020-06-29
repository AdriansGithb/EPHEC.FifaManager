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

namespace MatchManager_UI
{
    public partial class frmMM_HomePage : Form
    {
        public frmMM_HomePage()
        {
            try
            {
                InitializeComponent();
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
                BusinessErrors oError = new BusinessErrors(ex.Message);
                throw oError;
            }
        }


    }
}
