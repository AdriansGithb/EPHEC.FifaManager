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
    public class InscriptMatchData
    {
        private string _Connection = "Server=MSI\\SQLEXPRESS;Database=Fifa_Manager;User Id=UserMatchManagement;Password=;";

        //inscrit les joueurs de la datatable dans la BD
        public void SendMatchRegistrationsData(DataTable registrationTab)
        {
            try
            {
                using (SqlConnection oCon = new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;

                    oCon.Open();
                    //appel de la procédure stockée
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "[sch_MatchManagement].SP_Insert_InscriptionMatch";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    SqlParameter oPrmtrTab = new SqlParameter("@jrs_a_inscrire_tab", registrationTab);
                    cmd.Parameters.Add(oPrmtrTab);

                    cmd.ExecuteNonQuery();

                    oCon.Close();

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

        //desinscrit les joueurs de la datatable dans la BD
        public void SendMatchUnsubscriptionsData(DataTable unsubscribeTab)
        {
            try
            {
                using (SqlConnection oCon = new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;

                    oCon.Open();
                    //appel de la procédure stockée
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "[sch_MatchManagement].SP_Delete_InscriptionMatch";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    SqlParameter oPrmtrTab = new SqlParameter("@jrs_a_desinscrire_tab", unsubscribeTab);
                    cmd.Parameters.Add(oPrmtrTab);

                    cmd.ExecuteNonQuery();

                    oCon.Close();

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
