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

        //fonction permettant de charger les données de la form en fonction des paramètres de l'objet reçu, et des types de résultats dispos dans la BD
        private void frmModifResult_Load(object sender, EventArgs e)
        {
            try
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
        
        //fermer la fenêtre si on clique sur annuler
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }

        //envoi des nouveaux résultats vers la BD, via la BL, en cliquant sur Sauver
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //transformation de l'item en MdlTypeResult
                MdlTypeResult slctdResDom = (MdlTypeResult) lstbxResEqpDom.SelectedItem;
                MdlTypeResult slctdResVis = (MdlTypeResult) lstbxResEqpVis.SelectedItem;

                //vérification de modification avant changement
                if ((slctdResDom.Id != resAModifier.ResDomTypeID) ||
                    (slctdResVis.Id != resAModifier.ResVstTypeID))
                {
                    ResultatsServices oServices = new ResultatsServices();
                    oServices.SetResultat(resAModifier.Match_ID, slctdResDom.Id, slctdResVis.Id,
                        resAModifier.LastUpdate);
                    MessageBox.Show("Modifications sauvegardées");
                    this.Close();
                }
                else //si pas de changement
                {
                    MessageBox.Show("Vous n'avez pas effectué de modification à sauvegarder");
                }
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
