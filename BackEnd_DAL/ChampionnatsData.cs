using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ChampionnatsData
    {
        public List<Championnats> SelectAllChampionnats()
        {
            //récupération des championnats
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Championnats> listChamps = ctx.SP_SelectAllChampionnats().ToList();
            return listChamps;
        }
    }
}
