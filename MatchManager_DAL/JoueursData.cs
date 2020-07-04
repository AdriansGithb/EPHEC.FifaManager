using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;

namespace MatchManager_DAL
{
    public class JoueursData
    {
        private string _Connection = "Server=MSI\\SQLEXPRESS;Database=Fifa_Manager;User Id=UserMatchManagement;Password=;";

        //renvoit une datatable avec la liste des joueurs d'une équipe disponibles pour inscription au match donné en param
        public DataTable LoadAvailablePlayers_ForATeam_ForAMatch(int eqp_cochmp_id, int match_id)
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
                    cmd.CommandText = "[sch_MatchManagement].SP_SelectJoueursByEqp_AvailableForMatchInscription";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    SqlParameter oPrmtrEqp = new SqlParameter("@ceqp_cochmp_id", eqp_cochmp_id);
                    cmd.Parameters.Add(oPrmtrEqp);
                    SqlParameter oPrmtrMch = new SqlParameter("@match_id", match_id);
                    cmd.Parameters.Add(oPrmtrMch);

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

        //renvoit une datatable avec la liste des joueurs d'une équipe déjà inscrits au match donné en param
        public DataTable LoadRegisteredPlayers_ForATeam_ForAMatch(int eqp_cochmp_id, int match_id)
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
                    cmd.CommandText = "[sch_MatchManagement].SP_SelectJoueursByEqp_RegisteredForMatch";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    SqlParameter oPrmtrEqp = new SqlParameter("@ceqp_cochmp_id", eqp_cochmp_id);
                    cmd.Parameters.Add(oPrmtrEqp);
                    SqlParameter oPrmtrMch = new SqlParameter("@match_id", match_id);
                    cmd.Parameters.Add(oPrmtrMch);

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
