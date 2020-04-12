using BackEnd_DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_BL
{
    public class ConstChampServices
    {
        //obtenir le classement d'un championnat sélectionné
        public List<mdlConstChamp> GetClassement(int champ)
        {
            ConstChampData oData = new ConstChampData();
            List<Constitution_Championnat> lstCChmp = oData.SelectConstChamp(champ).ToList();

            //tranformation en modèles
            List<mdlConstChamp> returnLst = new List<mdlConstChamp>();

            foreach (Constitution_Championnat eqp in lstCChmp)
            {
                mdlConstChamp oCChmp = new mdlConstChamp();
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
