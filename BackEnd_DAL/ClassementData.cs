using Errors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ClassementData
    {
        //récupération de la liste des équipes du championnat "@champ"
        public List<SP_SelectClassement_Result> SelectClassement(int champ)
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectClassement_Result> lstClassmnt = ctx.SP_SelectClassement(champ).ToList();
                return lstClassmnt;
            }
            catch (SqlException ex)
            {
                throw new BusinessErrors(ex.Message);
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }
    }
}
