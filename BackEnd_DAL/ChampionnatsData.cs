using Errors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ChampionnatsData
    {
        // appel dans la DAL pour récupérer la liste des championnats
        public List<Championnats> SelectAllChampionnats()
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<Championnats> listChamps = ctx.SP_SelectAllChampionnats().ToList();
                return listChamps;
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

        //récupérer les données des 2 saisons d'un championnat déterminé
        public List<Saisons> SelectAllSsn1Champ(int champ_id)
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<Saisons> lstSsn = ctx.SP_SelectAllSsn1Champ(champ_id).ToList();
                return lstSsn;
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

        //procédure permettant de récupérer la liste des équipes inscrites à une saison envoyée en paramètre
        public List<SP_SelectEqpPerSsn_Result> SelectEqpPerSsn(int ssn_id)
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectEqpPerSsn_Result> lstEqp = ctx.SP_SelectEqpPerSsn(ssn_id).ToList();
                return lstEqp;
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

        //procédure permettant de récupérer la liste des équipes inscrites à un championnat envoyé en paramètre
        public List<SP_SelectEqpPerChamp_Result> SelectEqpPerChamp(int champ_id)
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectEqpPerChamp_Result> lstEqp = ctx.SP_SelectEqpPerChamp(champ_id).ToList();
                return lstEqp;
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
