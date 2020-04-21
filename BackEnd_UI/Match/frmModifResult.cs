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
        private MdlResultats resAModifier;
        // chargement de la form avec un objet résultat à modifier
        public frmModifResult(MdlResultats slctdRes)
        {
            InitializeComponent();
            resAModifier = slctdRes;
        }
        private void frmModifResult_Load(object sender, EventArgs e)
        {
            //charger les noms des labels avec les données de l'objet reçu
            lblMatch.Text = $"Match ID : {resAModifier.Match_ID}";
            lblEqpDom.Text = resAModifier.Nom_EqpDom;
            lblEqpVis.Text = resAModifier.Nom_EqpVisit;
            //chargement de la liste des types de résultats possibles, pour insérer dans les listbox domicile et visiteur
            ResultatsServices oServices = new ResultatsServices();
            //liste equipe domicile : affichage du libellé dans la liste, mais valeur de l'objet = l'ID du type résultat
            lstbxResEqpDom.DataSource = oServices.GetTypeResults();
            lstbxResEqpDom.DisplayMember = "Libelle";
            lstbxResEqpDom.ValueMember = "Id";
            //sélection par défaut du résultat de départ
            lstbxResEqpDom.SelectedValue = resAModifier.ResDomTypeID;
            //liste equipe visiteuse : affichage du libellé dans la liste, mais valeur de l'objet = l'ID du type résultat
            lstbxResEqpVis.DataSource = oServices.GetTypeResults();
            lstbxResEqpVis.DisplayMember = "Libelle";
            lstbxResEqpVis.ValueMember = "Id";
            //sélection par défaut du résultat de départ
            lstbxResEqpVis.SelectedValue = resAModifier.ResVstTypeID;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //transformation de l'item en MdlTypeResult
            MdlTypeResult slctdResDom = (MdlTypeResult)lstbxResEqpDom.SelectedItem;
            MdlTypeResult slctdResVis = (MdlTypeResult)lstbxResEqpVis.SelectedItem;

            //vérification de modification avant changement
            if ((slctdResDom.Id != resAModifier.ResDomTypeID) ||
                (slctdResVis.Id != resAModifier.ResVstTypeID))
            {
                ResultatsServices oServices = new ResultatsServices();
                oServices.SetResultat(resAModifier.Match_ID, slctdResDom.Id, slctdResVis.Id, resAModifier.LastUpdate);
                MessageBox.Show("changements effectués");
                this.Close();
            }
            else   //si pas de changement
            {
                MessageBox.Show("Vous n'avez pas effectué de modification");
            }
        }


    }
}
