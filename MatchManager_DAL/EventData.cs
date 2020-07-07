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
    public class EventData
    {
        private string _Connection = "Server=MSI\\SQLEXPRESS;Database=Fifa_Manager;User Id=UserMatchManagement;Password=;";

        //renvoie une datatable contenant la table des types événements
        public DataTable LoadEventTypeData()
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
                    cmd.CommandText = "[sch_MatchManagement].SP_SelectAllFromTypeEvents";
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

        //insère un événement de carte avec les suspensions liées à cet événement
        public void Insert1CardWithSuspensionMatchs(int ceqp_id, int match_sanction_id,int tevnt_id, DataTable susp_match_tab)
        {
            try
            {
                using (SqlConnection oCon = new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;

                    oCon.Open();
                    //appel de la procédure stockée
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "[sch_MatchManagement].SP_Insert_CardAndSuspensions";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    //remplissage de la datatable
                    SqlParameter oPrmtrCeqp = new SqlParameter("@ceqp_id", ceqp_id);
                    cmd.Parameters.Add(oPrmtrCeqp);
                    SqlParameter oPrmtrMatch = new SqlParameter("@match_sanction_id", match_sanction_id);
                    cmd.Parameters.Add(oPrmtrMatch);
                    SqlParameter oPrmtrTevnt = new SqlParameter("@tevnt_id", tevnt_id);
                    cmd.Parameters.Add(oPrmtrTevnt);
                    SqlParameter oPrmtrTab = new SqlParameter("@susp_match_tab", susp_match_tab);
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

        //insère un événement de x type_goal lié à un joueur
        public void InsertGoalEvents_1Player(int ceqp_id, int match_id, int tevnt_id, int nb_event)
        {
            try
            {
                using (SqlConnection oCon = new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;

                    oCon.Open();
                    //appel de la procédure stockée
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "[sch_MatchManagement].SP_Insert_GoalEvents";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    //remplissage de la datatable
                    SqlParameter oPrmtrCeqp = new SqlParameter("@ceqp_id", ceqp_id);
                    cmd.Parameters.Add(oPrmtrCeqp);
                    SqlParameter oPrmtrMatch = new SqlParameter("@match_id", match_id);
                    cmd.Parameters.Add(oPrmtrMatch);
                    SqlParameter oPrmtrTevnt = new SqlParameter("@tevnt_id", tevnt_id);
                    cmd.Parameters.Add(oPrmtrTevnt);
                    SqlParameter oPrmtrNbEvnt = new SqlParameter("@nbEvent", nb_event);
                    cmd.Parameters.Add(oPrmtrNbEvnt);

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
