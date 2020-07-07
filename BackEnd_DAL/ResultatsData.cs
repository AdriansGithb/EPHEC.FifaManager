using Errors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class ResultatsData
    {
        // Appel de la SP SelectResults qui renvoie tous les résultats d'une saison entrée en paramètre
        public List<SP_SelectResults_Result> SelectResultats(int champId, int ssn)
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectResults_Result> lstRes = new List<SP_SelectResults_Result>();
                //vérification de la récupération d'1 seule ou des 2 saisons
                if (ssn == 12)
                {
                    //si on doit récupérer 2 saisons, récupérer la 1ere puis ajout de la 2e
                    lstRes = ctx.SP_SelectResults(champId, 1).ToList();
                    lstRes.AddRange(ctx.SP_SelectResults(champId, 2).ToList());
                }
                //sinon, récupération de la 1e ou 2e saison uniquement
                else lstRes = ctx.SP_SelectResults(champId, ssn).ToList();

                return lstRes;
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
        // Appel de la SP SelectAllTypeResults qui renvoie tous les types de résultat de la BD (id et libelle)
        public List<SP_SelectAllTypeResults_Result> SelectAllTypeResults()
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectAllTypeResults_Result> lstTpRes = ctx.SP_SelectAllTypeResults().ToList();
                return lstTpRes;
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
        //Appel de la SP_ModifResult qui va modifier la valeur des résultats dans la table Matchs de la BD
        public void ModifResult(int mchId, int newResDom, int newResVst, DateTime lstUpdt)
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                ctx.SP_ModifResult(mchId, newResDom, newResVst, lstUpdt);
            }
            catch (SqlException ex)
            {
                throw new BusinessErrors(ex.Message);
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.InnerException.Message);
            }
        }
    }
}
