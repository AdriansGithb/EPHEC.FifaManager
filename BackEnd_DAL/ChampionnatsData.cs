using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ChampionnatsData
    {
        // appel dans la DAL pour récupérer la liste des championnats
        public List<Championnats> SelectAllChampionnats()
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Championnats> listChamps = ctx.SP_SelectAllChampionnats().ToList();
            return listChamps;
        }

        //récupérer les données des 2 saisons d'un championnat déterminé
        public List<Saisons> SP_SelectAllSsn1Champ(int champ_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Saisons> lstSsn = ctx.SP_SelectAllSsn1Champ(champ_id).ToList();
            return lstSsn;
        }

    }
}
