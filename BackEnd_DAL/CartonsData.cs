using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class CartonsData
    {
        //récupérer la liste des différents type de cartons existants
        public List<SP_SelectAllTypeCartons_Result> SelectAllTypeCartons()
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectAllTypeCartons_Result> rtrnList = ctx.SP_SelectAllTypeCartons().ToList();
                return rtrnList;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
