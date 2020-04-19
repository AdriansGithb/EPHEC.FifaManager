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
        public List<MdlResultats> GetResultats(int champId,int ssn)
        {
            //appel de la DAL pour aller récupérer les données dans la BD
            ResultatsData oData = new ResultatsData();
            List<SP_SelectResults_Result> lstRes = oData.SelectResultats(champId,ssn);
            List<MdlResultats> rtrnList = new List<MdlResultats>();

            //inclure les résultats dans un format modèle lisible partout
            foreach (SP_SelectResults_Result res in lstRes)
            {
                MdlResultats oRes = new MdlResultats();
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
