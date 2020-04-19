using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ResultatsData
    {
        public List<SP_SelectResults_Result> SelectResultats(int champId, int ssn)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<SP_SelectResults_Result> lstRes = new List<SP_SelectResults_Result>();
            //vérification de la récupération d'1 seule ou des 2 saisons
            if (ssn == 12)
            {
                //si on doit récupérer 2 saisons, récupérer la 1ere puis ajout de la 2e
                lstRes = ctx.SP_SelectResults(champId, 1).ToList();
                lstRes.AddRange(ctx.SP_SelectResults(champId, 2).ToList()); 
            }
            //sinon, récupération de la 1e ou 2e saison uniquement
            else lstRes = ctx.SP_SelectResults(champId,ssn).ToList();

            return lstRes;
        }
    }
}
