﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;
using Models;

namespace MatchManager_DAL
{
    public class MatchsData
    {
        private string _Connection = "Server=MSI\\SQLEXPRESS;Database=Fifa_Manager;User Id=UserMatchManagement;Password=;";

        //renvoit une datatable contenant la liste des matchs du jour
        public DataTable LoadMatchOfTheDayData(DateTime _today)
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
                    cmd.CommandText = "[sch_MatchManagement].SP_SelectMatchsOfTheDay";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;

                    SqlParameter oPrmtrDate = new SqlParameter("@dateOfTheDay", _today.Date);
                    cmd.Parameters.Add(oPrmtrDate);

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

        //renvoit une datatable contenant les scores du match envoyé en param
        public DataRow LoadMatchScores(int match_id)
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
                    cmd.CommandText = "[sch_MatchManagement].SP_SelectMatchScores";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = oCon;
                    SqlParameter oPrmtrMch = new SqlParameter("@match_id", match_id);
                    cmd.Parameters.Add(oPrmtrMch);

                    //remplissage de la datatable
                    SqlDataAdapter oAdapter = new SqlDataAdapter(cmd);
                    oAdapter.Fill(oTab);

                    oCon.Close();
                    oAdapter.Dispose();

                    return oTab.Rows[0];
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
