﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class CalendrierData
    {
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
        public void SP_InsertUpdateMtchClndr(int mch_ID, DateTime? mch_date, int ssn_Id, int mch_EqpDom_CoChmp_ID, int mch_EqpVisit_CoChmp_ID, DateTime? mch_LastUpdate)
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

        //procédure permettant de recevoir la liste des matchs des équipes passées en paramètre, à la date donnée en paramètre
        public List<SP_CheckDateMatchPossible_Result> SP_CheckDateMatchPossible(DateTime slctdDate, int eqpDom_CoChmp_ID, int eqpVisit_CoChmp_ID)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<SP_CheckDateMatchPossible_Result> rtrnList =
                ctx.SP_CheckDateMatchPossible(slctdDate, eqpDom_CoChmp_ID, eqpVisit_CoChmp_ID).ToList();
            return rtrnList;
        }
    }
}
