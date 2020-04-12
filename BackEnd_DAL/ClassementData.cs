using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ClassementData
    {
        public List<Constitution_Championnat> SelectClassement(int champ)
        {
            //récupération de la liste des équipes du championnat @champ
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Constitution_Championnat> listCoChmp = ctx.SP_SelectConstChamp(champ).ToList();
            return listCoChmp;
        }
    }
}
