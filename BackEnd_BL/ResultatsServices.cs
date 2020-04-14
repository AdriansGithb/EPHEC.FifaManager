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
                oRes.match_ID = res.Match_ID;
                oRes.date = (DateTime)res.Date;
                oRes.nom_EqpDom = res.Equipe_Domicile;
                oRes.nom_EqpVisit = res.Equipe_Visiteuse;
                oRes.goalsDom = (int)res.Goals_Domicile;
                oRes.goalsVisit = (int) res.Goals_Visiteur;
                oRes.resultDom = res.Resultat_Domicile;
                oRes.resultVisit = res.Resultat_Visiteur;

                rtrnList.Add(oRes);
            }

            return rtrnList;
        }
    }
}
