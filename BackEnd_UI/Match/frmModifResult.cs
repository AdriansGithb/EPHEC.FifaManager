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
        // chargement de la form avec un objet résultat à modifier
        public frmModifResult(MdlResultats resAModifier)
        {
            InitializeComponent();
            //charger les noms des labels avec les données de l'objet reçu
            lblMatch.Text = $"Match ID : {resAModifier.Match_ID}";
            lblEqpDom.Text = resAModifier.Nom_EqpDom;
            lblEqpVis.Text = resAModifier.Nom_EqpVisit;
            //chargement de la liste des types de résultats possibles, pour insérer dans les listbox domicile et visiteur
            ResultatsServices oServices = new ResultatsServices();
            //liste equipe domicile
            lstbxResEqpDom.DataSource = oServices.GetTypeResults();
            lstbxResEqpDom.ValueMember = "Libelle";
            lstbxResEqpDom.SelectedValue= resAModifier.ResultDom;
            //liste equipe visiteuse
            lstbxResEqpVis.DataSource = oServices.GetTypeResults();
            lstbxResEqpVis.ValueMember = "Libelle";
            lstbxResEqpVis.SelectedValue = resAModifier.ResultVisit;

        }


    }
}
