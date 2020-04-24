using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class CalendrierData
    {
        //procédure permettant de récupérer les données des 2 saisons d'un championnat déterminé
        public List<Saisons> SP_SelectAllSsn1Champ(int champ_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Saisons> lstSsn = ctx.SP_SelectAllSsn1Champ(champ_id).ToList();
            return lstSsn;
        }
    }
}
