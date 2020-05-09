using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        //obtenir la liste des équipes ayant plus de 5 joueurs inscrits pour la saison 2
        public List<SP_SelectEqpPlus5Joueurs_Ssn2_byChamp_Result> SP_SelectEqpPlus5Joueurs_Ssn2_byChamp(int champ_id)
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                List<SP_SelectEqpPlus5Joueurs_Ssn2_byChamp_Result> rtrnList =
                    ctx.SP_SelectEqpPlus5Joueurs_Ssn2_byChamp(champ_id).ToList();
                return rtrnList;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        //transferer un joueur
        public void SP_TransfererJoueur(int ceqp_id_jrATransferer, int cochmpId_nvlEqp, DateTime lstupdt )
        {
            try
            {
                Fifa_ManagerEntities ctx = new Fifa_ManagerEntities();
                ctx.SP_TransfererJoueur(ceqp_id_jrATransferer, cochmpId_nvlEqp, lstupdt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
