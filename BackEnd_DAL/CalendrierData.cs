using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class CalendrierData
    {
        //procédure permettant de récupérer les données des 2 saisons d'un championnat déterminé
        public List<Saisons> SP_SelectAllSsn1Champ(int champ_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Saisons> lstSsn = ctx.SP_SelectAllSsn1Champ(champ_id).ToList();
            return lstSsn;
        }

        //procédure permettant de récupérer la liste des matchs d'une saison déterminée
        public List<SP_SelectCalendrier_Result> SP_SelectCalendrier(int ssn_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<SP_SelectCalendrier_Result> lstClndr = ctx.SP_SelectCalendrier(ssn_id).ToList();
            return lstClndr;
        }

        //procédure permettant de récupérer la liste des équipes inscrites à une saison envoyée en paramètre
        public List<SP_SelectEqpPerSsn_Result> SP_SelectEqpPerSsn(int ssn_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<SP_SelectEqpPerSsn_Result> lstEqp = ctx.SP_SelectEqpPerSsn(ssn_id).ToList();
            return lstEqp;
        }

        //procédure permettant d'insérer ou mettre à jour un match dans la BD
        public void SP_InsertUpdateMtchClndr(int mch_ID, DateTime? mch_date, int ssn_Id, int mch_EqpDom_CoChmp_ID, int mch_EqpVisit_CoChmp_ID, DateTime mch_LastUpdate)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities(); 
            ctx.SP_InsertUpdateMatchClndr(mch_ID, ssn_Id, mch_date, mch_EqpDom_CoChmp_ID, mch_EqpVisit_CoChmp_ID, mch_LastUpdate);
        }

        //procédure permettant de mettre à jour la date de génération d'une saison
        public void SP_SetDateGnrClndr_Ssn(int ssn_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            ctx.SP_SetDateGnrClndr_Ssn(ssn_id);
        }
    }
}
