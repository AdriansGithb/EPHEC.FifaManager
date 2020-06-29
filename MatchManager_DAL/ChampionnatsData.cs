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
        public DataTable LoadChampData()
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
                throw new BusinessErrors(ex.Message);
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //renvoit une datatable contenant la liste des matchs de la/des saisons d'un championnat passé en paramètre
        public DataTable LoadMatchListData(int champ_id, int slctdSsn)
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
                    cmd.CommandText = "[sch_MatchManagement].SP_SelectMatchList";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    SqlParameter oPrmtrChamp = new SqlParameter("@champ_id",champ_id);
                    cmd.Parameters.Add(oPrmtrChamp);
                    SqlParameter oPrmtrSsn = new SqlParameter("@slctd_ssn", slctdSsn);
                    cmd.Parameters.Add(oPrmtrSsn);

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
