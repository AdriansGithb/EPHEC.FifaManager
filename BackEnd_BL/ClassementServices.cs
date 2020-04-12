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
            List<Constitution_Championnat> lstCChmp = oData.SelectClassement(champ).ToList();

            //tranformation en modèles
            List<mdlClassement> returnLst = new List<mdlClassement>();

            foreach (Constitution_Championnat eqp in lstCChmp)
            {
                mdlClassement oCChmp = new mdlClassement();
                oCChmp.Id = eqp.CoChmp_ID;
                oCChmp.Equipe_Id = eqp.CoChmp_Eqp_ID;
                oCChmp.Classement = eqp.CoChmp_Classement;
                oCChmp.Champ_Id = eqp.CoChmp_Champ_ID;

                returnLst.Add(oCChmp);
            }

            return returnLst;
        }
    }
}
