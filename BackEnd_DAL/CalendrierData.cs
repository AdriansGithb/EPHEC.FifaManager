using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    class CalendrierData
    {
        public string FN_CheckGnrClndrPossible(int champ_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            return ctx.FN_CheckGnrClndrPossible(champ_id);
        }
    }
}
