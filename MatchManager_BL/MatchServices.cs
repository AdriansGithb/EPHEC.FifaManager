using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;

namespace MatchManager_BL
{
    public class MatchServices
    {
        //renvoit un bool pour dire si la date donnée en param est antérieure à la date du jour
        //renvoit également un bool pour dire si la date donnée est nulle
            public bool IsEarlierThanToday(out bool isNull,DateTime? dateToCompare)
        {
            try
            {
                bool isEarlier = isNull = false;
                //si la date reçue en paramètre est nulle
                if (!dateToCompare.HasValue)
                {
                    isNull = true;
                }
                else
                {
                    //transformer la date non nulle en objet Datetime utilisable
                    DateTime oDate = (DateTime) dateToCompare;
                    //comparer les jours des 2 dates: donne
                        // <0 si la date reçue est antérieure a la date du jour
                        // >=0 si la date reçue est égale ou postérieure à la date du jour
                    int resComparison = oDate.Day.CompareTo(DateTime.Today);
                    if (resComparison < 0)
                        isEarlier = true;
                }
                return isEarlier;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }
    }
}
