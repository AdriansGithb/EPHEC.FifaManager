using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class JoueursData
    {
        //récupération des joueurs non inscrits à une équipe dans un championnat envoyé en paramètre
        public List<Joueurs> SelectAllJoueursDispoByChamp(int champ_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Joueurs> rtrnList =
                ctx.SP_SelectAllJoueursDispoByChamp(champ_id).ToList();
            return rtrnList;
        }

        //récupération des joueurs inscrits dans une équipe envoyée en paramètre
        public List<Joueurs> SelectAllJoueursByEqp(int eqp_cochamp_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Joueurs> rtrnList =
                ctx.SP_SelectAllJoueursByEqp(eqp_cochamp_id).ToList();
            return rtrnList;
        }

        //récupération des joueurs inscrits pour la saison 2 d'un championnat, dans une équipe envoyée en paramètre
        public List<SP_SelectAllJoueursByEqp_ForSsn2_Result> SelectAllJoueursByEqp_ForSsn2(int eqp_cochamp_id)
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectAllJoueursByEqp_ForSsn2_Result> rtrnList =
                    ctx.SP_SelectAllJoueursByEqp_ForSsn2(eqp_cochamp_id).ToList();
                return rtrnList;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
