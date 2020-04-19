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
using Models;

namespace BackEnd_UI.Match
{
    public partial class frmModifResult : Form
    {
        private int matchId;
        public frmModifResult()
        {
            InitializeComponent();
        }

        private void frmModifResult_Load(object sender, EventArgs e)
        {            
            matchId = frmResultats.ResAModifier.Match_ID;
            lblMatch.Text = $"Match ID : {frmResultats.ResAModifier.Match_ID}";
            lblEqpDom.Text = frmResultats.ResAModifier.Nom_EqpDom;
            lblEqpVis.Text = frmResultats.ResAModifier.Nom_EqpVisit;
            ResultatsServices oServices = new ResultatsServices();
            lstbxResEqpDom.DataSource = oServices.GetTypeResults();
            lstbxResEqpDom.ValueMember = "Libelle";
            lstbxResEqpDom.SelectedValue = frmResultats.ResAModifier.ResultDom;
            lstbxResEqpVis.DataSource = oServices.GetTypeResults();
            lstbxResEqpVis.ValueMember = "Libelle";
            lstbxResEqpVis.SelectedValue = frmResultats.ResAModifier.ResultVisit;

        }

    }
}
