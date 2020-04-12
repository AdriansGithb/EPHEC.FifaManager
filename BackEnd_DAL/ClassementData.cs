using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ClassementData
    {
        public List<SP_SelectClassement_Result> SelectClassement(int champ)
        {
            //récupération de la liste des équipes du championnat @champ
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<SP_SelectClassement_Result> lstClassmnt = ctx.SP_SelectClassement(champ).ToList();
            return lstClassmnt;
        }
    }
}
