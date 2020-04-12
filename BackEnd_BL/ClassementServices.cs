using BackEnd_DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_BL
{
    public class ClassementServices
    {
        //obtenir le classement d'un championnat sélectionné
        public List<mdlClassement> GetClassement(int champ)
        {
            ClassementData oData = new ClassementData();
            List<SP_SelectClassement_Result> lstClassRes = oData.SelectClassement(champ).ToList();

            //tranformation en modèles classement
            List<mdlClassement> returnLst = new List<mdlClassement>();

            foreach (SP_SelectClassement_Result eqp in lstClassRes)
            {
                mdlClassement oClassement = new mdlClassement();
                oClassement.position = eqp.CoChmp_Classement;
                oClassement.nomEqp = eqp.Eqp_Nom;
                oClassement.eqpId = eqp.Eqp_ID;

                returnLst.Add(oClassement);
            }

            return returnLst;
        }
    }
}
