using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Errors;
using MatchManager_DAL;
using Models;

namespace MatchManager_BL
{
    public class EventsServices
    {
        //sauvegarde des cartons et suspensions
        public void SaveCardEvents(int nbEvent , MdlJoueursParEquipe joueur, MdlMatchMM matchOrigineSanction, MdlTypeEvent card, List<MdlMatchMM> matchSuspList)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    //variables utiles pour l'inscription de la carte et de ses matchs effectifs de suspension
                    int ceqp_id = joueur.CEqp_Id;
                    int match_sanction_id = matchOrigineSanction.Match_ID;
                    int tevnt_id = card.Id;
                    
                    //boucle d'insertion des events + suspensions
                    int indexCount = 0;
                    EventData oData = new EventData();
                    //tant qu'il reste des events à insérer
                    for (int i = 0; i < nbEvent; i++)
                    {
                        //création de la datatable
                        DataTable suspMatchsTab = new DataTable("susp_match_tab");
                        suspMatchsTab.Columns.Add("Susp_Mch_ID", typeof(int));
                        for(int j=0;j<card.Nb_Jours_Suspension ;j++)
                        {
                            DataRow oRow = suspMatchsTab.NewRow();
                            //si il est encore possible d'insérer des matchs de suspension, insérer un id
                            if (indexCount < matchSuspList.Count)
                                oRow["Susp_Mch_ID"] = matchSuspList[indexCount].Match_ID;
                            //sinon insérer des id nulls
                            else oRow["Susp_Mch_ID"] = DBNull.Value;
                            suspMatchsTab.Rows.Add(oRow);
                            indexCount++;
                        }
                        //inscription de l'événement et des matchs qui lui sont liés
                        oData.Insert1CardWithSuspensionMatchs(ceqp_id,match_sanction_id, tevnt_id, suspMatchsTab);
                    }
                    
                    scope.Complete();
                }
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

        //sauvegarde des goals
        public void SaveGoalEvents(int nbEvent, MdlJoueursParEquipe buteur, MdlMatchMM match, MdlTypeEvent type_goal)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    //variables utiles pour l'inscription du/des goals
                    int ceqp_id = buteur.CEqp_Id;
                    int match_id = match.Match_ID;
                    int tevnt_id = type_goal.Id;

                    EventData oData = new EventData();
                    oData.InsertGoalEvents_1Player(ceqp_id, match_id, tevnt_id, nbEvent);

                    scope.Complete();
                }
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
