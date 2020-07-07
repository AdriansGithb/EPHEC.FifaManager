using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Errors;
using MatchManager_DAL;
using Models;

namespace MatchManager_BL
{
    public class MatchServices
    {
        //obtenir la liste du/des matchs du jour
        public List<MdlMatchMM> GetMatchsOfTheDay()
        {
            try
            {
                 MatchsData oData = new MatchsData();
                 List<MdlMatchMM> matchLst = new List<MdlMatchMM>();
                 string dateString;
                 // réception de la datatable contenant les matchs
                 DataTable oTab = oData.LoadMatchOfTheDayData(DateTime.Now)/*(new DateTime(2020,7,4))*/;
                 DataTableReader oReader = oTab.CreateDataReader();
                 // transformation des objets de la datatable en liste de modèles matchs
                 while (oReader.Read())
                 {
                     MdlMatchMM oMatch;

                     dateString = oReader.GetDateTime(1).ToShortDateString();
                     oMatch =
                         new MdlMatchMM(oReader.GetInt32(0), oReader.GetDateTime(1), dateString, oReader.GetInt32(2), oReader.GetString(3),oReader.GetInt32(4), oReader.GetString(5), oReader.GetInt32(6));
                     oMatch.LastUpdate = oReader.GetDateTime(7);
                     matchLst.Add(oMatch);
                 }
                 oReader.Close();
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

        //renvoie une liste de matchs pour lesquels l'inscription des joueurs est encore modifiable
        public List<MdlMatchMM> GetPlayersInscription_StillEditable_MatchList(int champ_id, int slctdSsn)
        {
            try
            {
                //récupération de la liste complète des matchs du championnat sélectionné
                ChampionnatsServices oServices = new ChampionnatsServices();
                List<MdlMatchMM> fullMatchList = oServices.GetFullMatchList(champ_id, slctdSsn);

                //tri de la liste complète : création d'une liste ne comprenant que les matchs dont la date est postérieure à la date du jour
                List<MdlMatchMM> rtrnList = new List<MdlMatchMM>();

                foreach (MdlMatchMM oMatch in fullMatchList)
                {
                    bool isLaterThanToday = IsLaterThanToday(oMatch.Date);
                    if (isLaterThanToday)
                        rtrnList.Add(oMatch);
                }

                return rtrnList;
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

        //renvoie un bool pour dire si la date donnée en param est postérieure à la date du jour
        //renvoie false si la date en param est nulle
        public bool IsLaterThanToday(DateTime? dateToCompare)
        {
            try
            {
                bool isLater = false;
                if (dateToCompare.HasValue)
                {
                    //transformer la date non nulle en objet Datetime utilisable
                    DateTime matchDate = (DateTime) dateToCompare;
                    //comparer les jours des 2 dates: donne
                        // <0 si la date du jour est antérieure a la date du match
                        // >=0 si la date du jour est égale ou postérieure à la date du match
                    int resComparison = DateTime.Now.Date.CompareTo(matchDate.Date);
                    if (resComparison < 0)
                        isLater = true;
                }
                return isLater;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //renvoie la liste complète des types de résultats
        public List<MdlTypeResult> GetResultTypes()
        {
            try
            {
                ResultData oData = new ResultData();
                List<MdlTypeResult> rtrnList = new List<MdlTypeResult>();

                DataTable oTab = oData.LoadResultTypeData();
                DataTableReader oReader = oTab.CreateDataReader();

                while (oReader.Read())
                {
                    MdlTypeResult oType = new MdlTypeResult();
                    oType.Id = oReader.GetInt32(0);
                    oType.Libelle = oReader.GetString(1);

                    rtrnList.Add(oType);
                }
                oReader.Close();
                return rtrnList;
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

        //renvoie la liste complète des types d'événements
        public List<MdlTypeEvent> GetEventTypes()
        {
            try
            {
                EventData oData = new EventData();
                List<MdlTypeEvent> rtrnList = new List<MdlTypeEvent>();

                DataTable oTab = oData.LoadEventTypeData();
                DataTableReader oReader = oTab.CreateDataReader();

                while (oReader.Read())
                {
                    MdlTypeEvent oType = new MdlTypeEvent();
                    oType.Id = oReader.GetInt32(0);
                    oType.Libelle = oReader.GetString(1);
                    if (oReader.IsDBNull(2) == false)
                    {
                        oType.Nb_Jours_Suspension = oReader.GetInt16(2);
                        oType.Susp_Next_Match = oReader.GetBoolean(3);
                    }
                    rtrnList.Add(oType);
                }
                oReader.Close();
                return rtrnList;
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

        //renvoie le score d'un match
        public void GetMatchScore(out int scoreDom, out int scoreVisit, int match_id)
        {
            try
            {
                MatchsData oData = new MatchsData();
                DataRow scoreRow = oData.LoadMatchScores(match_id);
                scoreDom = (int)scoreRow[0];
                scoreVisit = (int)scoreRow[1];
                if (scoreDom < 0)
                    scoreDom = 0;
                if (scoreVisit < 0)
                    scoreVisit = 0;
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

        //renvoie la liste des matchs restants après une date de match de début de comparaison
        public List<MdlMatchMM> GetMatchsRestantsList(int ceqp_id, DateTime date_debut )
        {
            try
            {
                MatchsData oData = new MatchsData();
                List<MdlMatchMM> matchLst = new List<MdlMatchMM>();
                string dateString;
                // réception de la datatable contenant les matchs
                DataTable oTab = oData.LoadMatchsRestantData(ceqp_id,date_debut);
                DataTableReader oReader = oTab.CreateDataReader();
                // transformation des objets de la datatable en liste de modèles matchs
                while (oReader.Read())
                {
                    MdlMatchMM oMatch;

                    dateString = oReader.GetDateTime(1).ToShortDateString();
                    oMatch =
                        new MdlMatchMM(oReader.GetInt32(0), oReader.GetDateTime(1), dateString, oReader.GetInt32(2), oReader.GetString(3), oReader.GetInt32(4), oReader.GetString(5), oReader.GetInt32(6));

                    matchLst.Add(oMatch);
                }
                oReader.Close();
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

        //sauvegarder les résultats d'une feuille de match
        public void SetMatchResults(int match_id, int typResDom, int typResVisit, DateTime lstupdt)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    MatchsData oData = new MatchsData();
                    oData.InsertMatchResults(match_id,typResDom, typResVisit, lstupdt);

                    scope.Complete();
                }
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
