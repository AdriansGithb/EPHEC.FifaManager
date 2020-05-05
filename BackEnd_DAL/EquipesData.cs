using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public class EquipesData
    {
        //enregistrement, dans la BD, d'un nouveau joueur inscrit dans une équipe pour les 2 saisons d'un championnat
        public void SP_InsertJoueur_Eqp(int jr_id, int eqp_cochmp_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            ctx.SP_InsertJoueur_Eqp(jr_id,eqp_cochmp_id);
        }

        //suppression de l'inscription d'un joueur à une équipe, dans la bd, pour les 2 saisons d'un championnat
        public void SP_DeleteJoueur_Eqp(int jr_id, int eqp_cochmp_id)
        {
            Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
            ctx.SP_DeleteJoueur_Eqp(jr_id, eqp_cochmp_id);
        }

    }
}
