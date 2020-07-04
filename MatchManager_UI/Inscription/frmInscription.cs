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
using Models;

namespace MatchManager_UI.Inscription
{
    public partial class frmInscription : Form
    {
        private MdlMatchMM slctdMatch;
        public frmInscription(MdlMatchMM slctdMatch)
        {
            try
            {
                InitializeComponent();
                this.slctdMatch = slctdMatch;
                LoadFields();
            }
            catch (BusinessErrors ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadFields()
        {
            try
            {
                this.lblMatch.Text = slctdMatch.NomString;
            }
            catch(Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }
    }
}
