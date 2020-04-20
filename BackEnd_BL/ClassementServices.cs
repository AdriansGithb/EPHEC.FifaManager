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
        public List<MdlClassement> GetClassement(int champ)
        {
            ClassementData oData = new ClassementData();
            List<SP_SelectClassement_Result> lstClassRes = oData.SelectClassement(champ).ToList();

            //tranformation en modèles classement
            List<MdlClassement> returnLst = new List<MdlClassement>();

            foreach (SP_SelectClassement_Result eqp in lstClassRes)
            {
                MdlClassement oClassement = new MdlClassement();
                oClassement.Position = (lstClassRes.IndexOf(eqp)+1);
                oClassement.Pts=eqp.Points;
                oClassement.NomEqp = eqp.Eqp_Nom;
                oClassement.EqpId = eqp.Eqp_ID;

                returnLst.Add(oClassement);
            }

            return returnLst;
        }
    }
}
