using Errors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchManager_DAL
{
    public class ResultData
    {
        private string _Connection = "Server=MSI\\SQLEXPRESS;Database=Fifa_Manager;User Id=UserMatchManagement;Password=;";

        //renvoit une datatable contenant la table des types de résultats
        public DataTable LoadResultTypeData()
        {
            try
            {
                using (SqlConnection oCon = new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;
                    DataTable oTab = new DataTable();

                    oCon.Open();
                    //appel de la procédure stockée
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "[sch_MatchManagement].SP_SelectAllFromTypeResults";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    //remplissage de la datatable
                    SqlDataAdapter oAdapter = new SqlDataAdapter(cmd);
                    oAdapter.Fill(oTab);

                    oCon.Close();
                    oAdapter.Dispose();

                    return oTab;
                }
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
