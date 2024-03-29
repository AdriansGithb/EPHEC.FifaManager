﻿using System;
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

namespace BackEnd_UI.Cartons
{
    public partial class frmCartons : Form
    {
        public frmCartons()
        {
            InitializeComponent();
        }

        private void frmCartons_Load(object sender, EventArgs e)
        {
            try
            {
                boxChampSelection_Load();
                boxCartSelection_Load();
                dtgrdCartons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgrdCartons_Load();
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

        //chargement de la liste des championnats
        public void boxChampSelection_Load()
        {
            try
            {
                ChampionnatsServices oService = new ChampionnatsServices();
                List<MdlChampionnat> lstChamp = new List<MdlChampionnat>();
                //insertion d'une sélection de tous les championnats
                MdlChampionnat oAllChamps = new MdlChampionnat(-1, "Tous", 0);
                lstChamp.Add(oAllChamps);
                //insertion de la liste des championnats
                lstChamp.AddRange(oService.GetChampionnats());
                //insertion de la liste dans la combobox
                boxChampSelection.DataSource = lstChamp;
                boxChampSelection.DisplayMember = "NomString";
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //chargement de la liste des types de cartons
        public void boxCartSelection_Load()
        {
            try
            {
                CartonsServices oService = new CartonsServices();
                List<MdlTypeCarton> lstCartTypes = new List<MdlTypeCarton>();
                //insertion d'une sélection de tous les types de cartons
                MdlTypeCarton oAllCarts = new MdlTypeCarton();
                oAllCarts.Id = -1;
                oAllCarts.Libelle = "Tous";
                lstCartTypes.Add(oAllCarts);
                //insertion de la liste des types de cartons
                lstCartTypes.AddRange(oService.GetAllTypesCartons());
                //insertion de la liste dans la combobox
                boxCartSelection.DataSource = lstCartTypes;
                boxCartSelection.DisplayMember = "Libelle";
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //chargement du datagridCartons en fonction des filtres sélectionnés
        public void dtgrdCartons_Load()
        {
                try
                {
                    MdlChampionnat slctdChamp = (MdlChampionnat)boxChampSelection.SelectedItem;
                    MdlTypeCarton slctdTypeCarton = (MdlTypeCarton)boxCartSelection.SelectedItem;
                    CartonsServices oServices = new CartonsServices();
                    dtgrdCartons.DataSource = oServices.GetFilteredCartonsList(slctdChamp, slctdTypeCarton);
                }
                catch (Exception ex)
                {
                    throw new BusinessErrors(ex.Message);
                }
        }

        //click sur filtrer : filtrer le datagrid en fonction de la sélection des filtres
        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            try
            {
                dtgrdCartons_Load();
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
