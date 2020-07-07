using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;
using MatchManager_DAL;
using Models;

namespace MatchManager_BL
{
    public class JoueursServices
    {
        //renvoie la liste des joueurs d'une équipe dispo pour un match donné en param
        public List<MdlJoueursParEquipe> GetAvailableTeamPlayersList_ForAMatch(int eqp_cochmp_id, int match_id)
        {
            try
            {
                JoueursData oData = new JoueursData();
                List<MdlJoueursParEquipe> jrList = new List<MdlJoueursParEquipe>();
                // réception de la datatable contenant les joueurs
                DataTable oTab = oData.LoadAvailablePlayers_ForATeam_ForAMatch(eqp_cochmp_id,match_id);
                DataTableReader oReader = oTab.CreateDataReader();
                // transformation des objets de la datatable en liste de modèles joueursParEqp
                while (oReader.Read())
                {
                    MdlJoueursParEquipe oJoueur;

                    oJoueur =
                        new MdlJoueursParEquipe(oReader.GetInt32(0), oReader.GetString(1),oReader.GetString(2),oReader.GetDateTime(3));

                    jrList.Add(oJoueur);
                }
                oReader.Close();
                return jrList;
            }
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //renvoie la liste des joueurs d'une équipe déjà inscrits pour un match donné
        public List<MdlJoueursParEquipe> GetRegisteredTeamPlayersList_ForAMatch(int eqp_cochmp_id, int match_id)
        {
            try
            {
                JoueursData oData = new JoueursData();
                List<MdlJoueursParEquipe> jrList = new List<MdlJoueursParEquipe>();
                // réception de la datatable contenant les joueurs
                DataTable oTab = oData.LoadRegisteredPlayers_ForATeam_ForAMatch(eqp_cochmp_id, match_id);
                DataTableReader oReader = oTab.CreateDataReader();
                // transformation des objets de la datatable en liste de modèles joueursParEqp
                while (oReader.Read())
                {
                    MdlJoueursParEquipe oJoueur;

                    oJoueur =
                        new MdlJoueursParEquipe(oReader.GetInt32(0), oReader.GetString(1), oReader.GetString(2), oReader.GetDateTime(3));

                    jrList.Add(oJoueur);
                }
                oReader.Close();
                return jrList;
            }
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

    }
}
