using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Errors;
using Models;

namespace MatchManager_BL
{
    public class EventsServices
    {
        //sauvegarde des cartons et suspensions
        public void SaveCardEvents(int nbEvent , MdlJoueursParEquipe joueur,MdlTypeEvent card, List<MdlMatchMM> matchSuspList)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {

                    //for (int i = 0; i < nbEvent; i++)
                    //{
                    //    for (int j = 0; j < card.Nb_Jours_Suspension; j++)
                    //    {

                    //    }
                    //}
                    
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
