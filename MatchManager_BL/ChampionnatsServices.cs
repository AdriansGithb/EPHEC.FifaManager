﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;
using MatchManager_DAL;
using Models;

namespace MatchManager_BL
{
    public class ChampionnatsServices
    {
        //renvoit une liste contenant les championnats de l'année en cours, ou futures
        public List<MdlChampionnat> GetChampsOfThisYearAndFuture()
        {
            try
            {
                List<MdlChampionnat> toSortList = GetAllChampionnats();
                List<MdlChampionnat> sortedList = new List<MdlChampionnat>();

                foreach (MdlChampionnat oChamp in toSortList)
                {
                    //si l'année du championnat est égale ou supérieure à l'année du jour : l'ajouter à la liste
                    if (oChamp.Annee >= DateTime.Now.Year)
                        sortedList.Add(oChamp);
                }

                return sortedList;
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

        // renvoit une liste contenant tous les championnats
        public List<MdlChampionnat> GetAllChampionnats()
        {
            try
            {
                List<MdlChampionnat> lstChamps = new List<MdlChampionnat>();
                ChampionnatsData oData = new ChampionnatsData();
                // réception de la datatable contenant les championnats
                DataTable oTab = oData.LoadChampData();
                DataTableReader oReader = oTab.CreateDataReader();
                // transformation des objets de la datatable en liste de modèles championnats
                while (oReader.Read())
                {
                    MdlChampionnat oChamp =
                        new MdlChampionnat(oReader.GetInt32(0), oReader.GetString(1), oReader.GetInt16(2));
                    lstChamps.Add(oChamp);
                }

                return lstChamps;
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

        // renvoit une liste contenant tous les matchs d'une / des saison(s) d'un championnat
        public List<MdlMatchList> GetFullMatchList(int champ_id, int slctdSsn)
        {
            try
            {
                List<MdlMatchList> matchLst = new List<MdlMatchList>();
                ChampionnatsData oData = new ChampionnatsData();
                string dateString;
                // réception de la datatable contenant les matchs
                DataTable oTab = oData.LoadMatchListData(champ_id,slctdSsn);
                DataTableReader oReader = oTab.CreateDataReader();
                // transformation des objets de la datatable en liste de modèles matchs
                while (oReader.Read())
                {
                    MdlMatchList oMatch;
                    // pour récupération de la date pouvant être nulle, vérifier si elle l'est ou non
                    if (oReader.IsDBNull(1))
                    {
                        dateString = "NoDate";                    
                        oMatch = 
                            new MdlMatchList(oReader.GetInt32(0), null,dateString,oReader.GetInt32(2),oReader.GetString(3),oReader.GetString(4));
                    }
                    else
                    {
                        dateString = oReader.GetDateTime(1).ToShortDateString();
                        oMatch =
                            new MdlMatchList(oReader.GetInt32(0), oReader.GetDateTime(1), dateString, oReader.GetInt32(2), oReader.GetString(3), oReader.GetString(4));
                    }
                    matchLst.Add(oMatch);
                }

                return matchLst;
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
    }
}
