using Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchManager_BL
{
    public class EquipesServices
    {
        public static int NbJoueursMax = 7;

        //vérifier le nb max de joueurs inscrits possible, renvoit true si seuil pas atteint
        public bool SeuilMaxJoueurs_OK(int nbJoueursAjoutes, int nbJoueursInscrits)
        {
            try
            {
                int nwTotal = nbJoueursAjoutes + nbJoueursInscrits;
                if (nwTotal <= NbJoueursMax)
                    return true;
                else return false;
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
