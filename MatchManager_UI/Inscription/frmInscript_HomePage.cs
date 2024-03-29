﻿using System;
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
using MatchManager_UI.Inscription;
using Models;

namespace MatchManager_UI
{
    public partial class frmInscript_HomePage : Form
    {
        public frmInscript_HomePage()
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
                boxChampSelection.DataSource = oServices.GetChampsOfThisYearAndFuture();
                boxChampSelection.DisplayMember = "NomString";
                boxChampSelection.SelectedIndex = 0;
            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //remplir la combobox de sélection d'un match
        //activer/désactiver le bouton inscrire si la liste de matchs est vide
        public void Load_MatchList(object sender, EventArgs e)
        {
            try
            {
                //récupérer l'id du championnat sélectionné
                MdlChampionnat slctdChamp = (MdlChampionnat) boxChampSelection.SelectedItem;
                int slctdSsn = checkRdbtnSelection();
                //récupérer la liste des matchs du championnat sélectionné, pour lesquels l'inscription est encore modifiable
                MatchServices oServices = new MatchServices();
                boxMatchSelection.DataSource = oServices.GetPlayersInscription_StillEditable_MatchList(slctdChamp.Id, slctdSsn);
                boxMatchSelection.DisplayMember = "NomString";
                boxMatchSelection.SelectedItem = 0;
                //activer/désactiver le bouton inscrire si la liste de matchs est vide
                if (boxMatchSelection.Items.Count > 0)
                    btn_InscrireJoueurs.Enabled = true;
                else btn_InscrireJoueurs.Enabled = false;
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

        private void btn_InscrireJoueurs_Click(object sender, EventArgs e)
        {
            try
            {
                MdlMatchMM slctdMatch = (MdlMatchMM)boxMatchSelection.SelectedItem;
                frmInscript_TeamSelection oFrmTeamSel = new frmInscript_TeamSelection(slctdMatch);
                oFrmTeamSel.Show();
            }
            catch (Exception ex)
            {
                BusinessErrors oError = new BusinessErrors(ex.Message);
                MessageBox.Show(oError.Message);
            }
        }
    }
}
