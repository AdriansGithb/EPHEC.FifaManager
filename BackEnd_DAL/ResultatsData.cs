using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ResultatsData
    {
        public List<SP_SelectResults_Result> SelectResultats(int ssn)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<SP_SelectResults_Result> lstRes = ctx.SP_SelectResults(ssn).ToList();
            return lstRes;
        }
    }
}
