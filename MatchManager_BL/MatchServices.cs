using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                 DataTable oTab = oData.LoadMatchOfTheDayData(DateTime.Now.AddDays(6));
                 DataTableReader oReader = oTab.CreateDataReader();
                 // transformation des objets de la datatable en liste de modèles matchs
                 while (oReader.Read())
                 {
                     MdlMatchMM oMatch;

                     dateString = oReader.GetDateTime(1).ToShortDateString();
                     oMatch =
                         new MdlMatchMM(oReader.GetInt32(0), oReader.GetDateTime(1), dateString, oReader.GetInt32(2), oReader.GetString(3),oReader.GetInt32(4), oReader.GetString(5), oReader.GetInt32(6));
                     
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

        //renvoit une liste de matchs pour lesquels l'inscription des joueurs est encore modifiable
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

        //renvoit un bool pour dire si la date donnée en param est postérieure à la date du jour
        //renvoit false si la date en param est nulle
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

        //
    }
}
