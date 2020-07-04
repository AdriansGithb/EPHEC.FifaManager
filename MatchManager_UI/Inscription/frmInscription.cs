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
        private bool eqpDom;

        //réception du match sélectionné, et du choix de l'équipe : 
            // eqpDom = true si équipe domicile sélectionnée, false si eqp visiteuse sélectionnée
        public frmInscription(MdlMatchMM slctdMatch, bool eqpDom)
        {
            try
            {
                InitializeComponent();
                this.slctdMatch = slctdMatch;
                this.eqpDom = eqpDom;
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
                switch (this.eqpDom)
                {
                    case true: this.lblEqp.Text = slctdMatch.Nom_EqpDom;
                        break;
                    case false: this.lblEqp.Text = slctdMatch.Nom_EqpVisit;
                        break;
                }
            }
            catch(Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }
    }
}
