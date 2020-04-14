using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd_DAL;
using Models;

namespace BackEnd_BL
{
    public class ResultatsServices
    {
        public List<mdlResultats> GetResultats(int ssn)
        {
            ResultatsData oData = new ResultatsData();
            List<SP_SelectResults_Result> lstRes = oData.SelectResultats(ssn);
            List<mdlResultats> rtrnList = new List<mdlResultats>();

            foreach (SP_SelectResults_Result res in lstRes)
            {
                mdlResultats oRes = new mdlResultats();
                oRes.Match_ID = res.Match_ID;
                oRes.Date = res.Date;
                oRes.Nom_EqpDom = res.Equipe_Domicile;
                oRes.Nom_EqpVisit = res.Equipe_Visiteuse;
                oRes.GoalsDom = res.Goals_Domicile;
                oRes.GoalsVisit = res.Goals_Visiteur;
                oRes.ResultDom = res.Resultat_Domicile;
                oRes.ResultVisit = res.Resultat_Visiteur;

                rtrnList.Add(oRes);
            }

            return rtrnList;
        }
    }
}
