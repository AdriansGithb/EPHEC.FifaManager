using Errors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatchManager_DAL;
using Models;

namespace MatchManager_BL
{
    public class EqpMatchServices
    {
        public static int NbJoueursMax = 7;
        public static int NbJoueursMin = 5;

        //vérifier le nb max de joueurs inscrits possible, renvoit true si seuil pas atteint
        public bool SeuilMaxJoueurs_OK(int nbJoueursAjoutes, int nbJoueursInscrits)
        {
            try
            {
                int nwTotal = nbJoueursAjoutes + nbJoueursInscrits;
                if (nwTotal <= NbJoueursMax)
                    return true;
                else return false;
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

        //vérifier le nb min de joueurs inscrits nécessaires pour qu'un match soit jouable
        //sur base d'une soustraction
        public bool SeuilMinJoueurs_OK(int nbJoueursEnMoins, int nbJoueursTotal)
        {
            try
            {
                int nwTotal = nbJoueursTotal - nbJoueursEnMoins;
                if (nwTotal >= NbJoueursMin)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }
        //sur base d'un seul nombre donné
        public bool SeuilMinJoueurs_OK(int nbJoueursTotal)
        {
            try
            {
                if (nbJoueursTotal >= NbJoueursMin)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //inscription de la liste sélectionnée (reçoit la nouvelle sélection de joueurs inscrits au match, et la précédente sélection)
        public void SaveModifications(List<MdlJoueursParEquipe> nwEqpList, List<MdlJoueursParEquipe> oldEqpList, MdlMatchMM match)
        {
            try
            {                
                //obtenir une liste d'inscriptions et une liste de désinscriptions à réaliser
                List<List<MdlJoueursParEquipe>> triLists = TrierInscriptions_Desinscriptions_Joueurs(nwEqpList, oldEqpList);
                List<MdlJoueursParEquipe> inscriptionList = triLists[0];
                List<MdlJoueursParEquipe> desinscriptionList = triLists[1];
                //si les 2 listes sont vides, l'utilisateur a sauvé sans qu'aucun changement n'ait réellement été fait sur la composition d'équipe
                if (inscriptionList.Count == 0 && desinscriptionList.Count == 0)
                    throw new BusinessErrors("Aucune modification d'équipe");
                //sinon, si au moins une des 2 contient des objets
                    //d'abord désinscrire puis inscrire sinon déclenche le trigger
                    //TR_InscriptMatchs_CheckMax7JrParEqp : empêche l’inscription de plus de 7 joueurs d’une même équipe à un même match, dans la BD
                else
                {                    
                    //désinscrire la liste de désinscriptions, si la liste contient des objets
                    if (desinscriptionList.Count > 0)
                        DesinscrireJoueurs_EqpMatch(desinscriptionList, match);

                    //inscrire la liste d'inscriptions, si la liste contient des objets
                    if (inscriptionList.Count > 0)
                        InscrireJoueurs_EqpMatch(inscriptionList, match);
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

        //vérifier si il y a eu des modifications dans la liste de l'équipe
        //renvoit true si il y a eu des modifs, et false sinon
        public bool CheckIfModification(List<MdlJoueursParEquipe> nwEqpList, List<MdlJoueursParEquipe> oldEqpList)
        {
            try
            {
                bool modif = false;
                if (nwEqpList.Count == oldEqpList.Count)
                {
                    foreach (MdlJoueursParEquipe oJoueur in nwEqpList)
                    {
                        if (oldEqpList.Contains(oJoueur) == false)
                            modif = true;
                    }
                }
                else modif = true;

                return modif;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //trier la nouvelle liste et l'ancienne liste : renvoi  à l'index .. :la liste de ...
        // 0 : liste des nouveaux joueurs inscrits
        // 1 : liste des joueurs désinscrits  
        public List<List<MdlJoueursParEquipe>> TrierInscriptions_Desinscriptions_Joueurs(List<MdlJoueursParEquipe> nwList, List<MdlJoueursParEquipe> oldList)
        {
            try
            {
                //création des listes triées
                List<MdlJoueursParEquipe> joueursInscritsList = new List<MdlJoueursParEquipe>();
                List<MdlJoueursParEquipe> jrDesinscritsList = oldList;
                //parcours de la liste modifiée pour connaître les joueurs inscrits
                foreach (MdlJoueursParEquipe oJoueur in nwList)
                {
                    //si le joueur inscrit dans la liste modifiée n'est pas présent dans la liste d'origine, l'ajouter dans la liste des nouveaux joueurs
                    if ((oldList.Find(jr => jr.CEqp_Id == oJoueur.CEqp_Id)) is null)
                    {
                        joueursInscritsList.Add(oJoueur);
                    }
                    //sinon, le joueur est présent dans la liste d'origine, et dans la nouvelle liste donc n'a pas été désinscrit
                    //donc on le retire de la liste des joueurs potentiellement désinscrits (jrDesinscritsList)
                    else jrDesinscritsList.Remove(oJoueur);
                }
                //en sortant de cette boucle, la liste joueursInscritsList comprend uniquement les joueurs qui n'étaient pas présents dans la liste d'origine
                //et la liste jrDesinscritsList ne comprend que les joueurs d'origine qui n'ont pas été trouvé dans la nwList
                //on rassemble les 2, dans l'ordre (d'abord la nouvelle, ensuite la 2e) et on renvoit
                List<List<MdlJoueursParEquipe>> rtrnList = new List<List<MdlJoueursParEquipe>>();
                rtrnList.Add(joueursInscritsList);
                rtrnList.Add(jrDesinscritsList);
                return rtrnList;
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

        //inscrire dans l'équipe envoyée en paramètre, la liste de joueurs envoyée en paramètre
        public void InscrireJoueurs_EqpMatch(List<MdlJoueursParEquipe> inscriptJrsList, MdlMatchMM match)
        {
            try
            {
                InscriptMatchData oData = new InscriptMatchData();
                DataTable insertTab = new DataTable();
                insertTab.Columns.Add("IMch_CEqp_ID", typeof(int));
                insertTab.Columns.Add("IMch_Mch_ID", typeof(int));
                insertTab.Columns.Add("CEqp_LastUpdate", typeof(DateTime));
                foreach (MdlJoueursParEquipe oJoueur in inscriptJrsList)
                {
                    insertTab.Rows.Add(oJoueur.CEqp_Id, match.Match_ID, oJoueur.LastUpdate);
                }

                oData.SendMatchRegistrationsData(insertTab);
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

        //désinscrire dans l'équipe envoyée en paramètre, la liste de joueurs envoyée en paramètre
        public void DesinscrireJoueurs_EqpMatch(List<MdlJoueursParEquipe> desinscriptJrsList, MdlMatchMM match)
        {
            try
            {
                InscriptMatchData oData = new InscriptMatchData();
                DataTable deleteTab = new DataTable();
                deleteTab.Columns.Add("IMch_CEqp_ID", typeof(int));
                deleteTab.Columns.Add("IMch_Mch_ID", typeof(int));
                deleteTab.Columns.Add("CEqp_LastUpdate", typeof(DateTime));
                foreach (MdlJoueursParEquipe oJoueur in desinscriptJrsList)
                {
                    deleteTab.Rows.Add(oJoueur.CEqp_Id, match.Match_ID, oJoueur.LastUpdate);
                }

                oData.SendMatchUnsubscriptionsData(deleteTab);
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
