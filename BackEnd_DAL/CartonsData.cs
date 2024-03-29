﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;

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
                throw new BusinessErrors(ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //récupérer la liste de tous les cartons enregistrés dans la BD
        public List<SP_SelectAllCartons_Result> SelectAllCartons()
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectAllCartons_Result> rtrnList = ctx.SP_SelectAllCartons().ToList();
                return rtrnList;
            }
            catch (SqlException ex)
            {
                throw new BusinessErrors(ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }
    }
}
