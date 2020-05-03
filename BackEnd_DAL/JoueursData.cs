using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class JoueursData
    {
        //récupération des joueurs non inscrits à une équipe dans un championnat envoyé en paramètre
        public List<Joueurs> SP_SelectAllJoueursDispoByChamp(int champ_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Joueurs> rtrnList =
                ctx.SP_SelectAllJoueursDispoByChamp(champ_id).ToList();
            return rtrnList;
        }

        //récupération des joueurs inscrits dans une équipe envoyée en paramètre
        public List<Joueurs> SP_SelectAllJoueursByEqp(int eqp_cochamp_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            List<Joueurs> rtrnList =
                ctx.SP_SelectAllJoueursByEqp(eqp_cochamp_id).ToList();
            return rtrnList;
        }

    }
}
