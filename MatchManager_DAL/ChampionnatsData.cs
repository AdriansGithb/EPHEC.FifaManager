using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;
using Microsoft.SqlServer.Server;

namespace MatchManager_DAL
{
    public class ChampionnatsData
    {
        private string _Connection = "Server=MSI\\SQLEXPRESS;Database=Fifa_Manager;User Id=UserMatchManagement;Password=;";

        //renvoit une datatable contenant le data de la table Championnats
        public DataTable LoadData()
        {
            try
            {
                using (SqlConnection oCon=new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;
                    DataTable oTab = new DataTable();

                    oCon.Open();
                    //appel de la procédure stockée
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "[sch_MatchManagement].SP_SelectAllChampionnats";
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
                BusinessErrors oError = new BusinessErrors(ex.Message);
                throw oError;
            }
            catch (Exception ex)
            {
                BusinessErrors oError=new BusinessErrors(ex.Message);
                throw oError;
            }
        }


    }
}
