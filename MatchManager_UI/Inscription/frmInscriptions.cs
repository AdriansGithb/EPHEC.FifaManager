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
    public partial class frmInscriptions : Form
    {
        public frmInscriptions()
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

        //choix d'un match, vérification des boutons actifs ou non
        private void boxMatchSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //bool isEarlier, isNull = false;
                //MatchServices oServices = new MatchServices();

                //MdlMatchList oMatch = (MdlMatchList) boxMatchSelection.SelectedItem;
                //isEarlier = oServices.IsEarlierThanToday(out isNull, oMatch.Date);
                //// si le match n'a pas de date, aucun bouton actif
                //if (isNull)
                //{
                //    btn_InscrireJoueurs.Enabled = false;
                //}
                ////sinon, si la date du match est antérieure à la date du jour
                ////permission d'inscrire des joueurs pour le match, mais pas d'accès à la feuille de match
                //else if (isEarlier)
                //{
                //    btn_InscrireJoueurs.Enabled = true;
                //}
                ////sinon, la date du match est égale ou postérieure à la date du jour
                ////permission de remplir la feuille de match
                //else
                //{
                //    btn_InscrireJoueurs.Enabled = false;
                //}

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
