using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd_DAL;
using Models;

namespace BackEnd_BL
{
    public class EquipesServices
    {
        public static int NbJoueursMin = 5;

        public static int NbJoueursMax = 10;

        //inscription de la liste sélectionnée (reçoit la sélection de joueurs à inscrire, l'équipe dans laquelle il faut les inscrire, le nb de joueurs inscrits dans l'équipe)
        public void SaveModifications(List<MdlJoueurs> nwEqpList, List<MdlJoueurs> oldEqpList, MdlEquipeChamp eqp)
        {
            try
            {                //obtenir une liste d'inscriptions et une liste de désinscriptions à réaliser
                List<List<MdlJoueurs>> triLists = TrierInscriptions_Desinscriptions_Joueurs(nwEqpList, oldEqpList);
                List<MdlJoueurs> inscriptionList = triLists[0];
                List<MdlJoueurs> desinscriptionList = triLists[1];
                //si les 2 listes sont vides, l'utilisateur a sauvé sans qu'aucun changement n'ait réellement été fait sur la composition d'équipe
                if (inscriptionList.Count == 0 && desinscriptionList.Count == 0)
                    throw new Exception("Aucune modification d'équipe");
                //sinon, si au moins une des 2 contient des objets
                else
                {                
                    //inscrire la liste d'inscriptions, si la liste contient des objets
                    if(inscriptionList.Count>0)
                        InscrireJoueurs_Eqp(inscriptionList,eqp);
                    //désinscrire la liste de désinscriptions, si la liste contient des objets
                    if (desinscriptionList.Count>0)
                        DesinscrireJoueurs_Eqp(desinscriptionList,eqp);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //vérifier si il y a eu des modifications dans la liste de l'équipe
        //renvoit true si il y a eu des modifs, et false sinon
        public bool CheckIfModification(List<MdlJoueurs> nwEqpList, List<MdlJoueurs> oldEqpList)
        {
            bool modif=false;
            if (nwEqpList.Count == oldEqpList.Count)
            {
                foreach (MdlJoueurs oJoueur in nwEqpList)
                {
                    if (oldEqpList.Contains(oJoueur) == false)
                        modif = true;
                }
            }
            else modif = true;
            return modif;
        }

        //trier la nouvelle liste et l'ancienne liste : renvoi  à l'index .. :la liste de ...
        // 0 : liste des nouveaux joueurs inscrits
        // 1 : liste des joueurs désinscrits  
        public List<List<MdlJoueurs>> TrierInscriptions_Desinscriptions_Joueurs(List<MdlJoueurs> nwList, List<MdlJoueurs> oldList)
        {
            try
            {
                //création des listes triées
                List<MdlJoueurs> nwJoueursList = new List<MdlJoueurs>();
                List<MdlJoueurs> jrDesinscritsList = oldList;
                //parcours de la liste modifiée pour connaître les joueurs inscrits
                foreach (MdlJoueurs oJoueur in nwList)
                {
                    //si le joueur inscrit dans la liste modifiée n'est pas présent dans la liste d'origine, l'ajouter dans la liste des nouveaux joueurs
                    if ((oldList.Find(jr => jr.Id == oJoueur.Id)) is null)
                    {
                        nwJoueursList.Add(oJoueur);
                    }
                    //sinon, le joueur est présent dans la liste d'origine, et dans la nouvelle liste donc n'a pas été désinscrit
                    //donc on le retire de la liste des joueurs potentiellement désinscrits (jrDesinscritsList)
                    else jrDesinscritsList.Remove(oJoueur);
                }
                //en sortant de cette boucle, la liste nwJoueursList comprend uniquement les joueurs qui n'étaient pas présents dans la liste d'origine
                //et la liste jrDesinscritsList ne comprend que les joueurs d'origine qui n'ont pas été trouvé dans la nwList
                //on rassemble les 2, dans l'ordre (d'abord la nouvelle, ensuite la 2e) et on renvoit
                List<List<MdlJoueurs>> rtrnList = new List<List<MdlJoueurs>>();
                rtrnList.Add(nwJoueursList);
                rtrnList.Add(jrDesinscritsList);
                return rtrnList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //inscrire dans l'équipe envoyée en paramètre, la liste de joueurs envoyée en paramètre
        public void InscrireJoueurs_Eqp(List<MdlJoueurs> inscriptJrsList, MdlEquipeChamp eqp)
        {
            try
            {
                EquipesData oData = new EquipesData();
                foreach (MdlJoueurs oJoueur in inscriptJrsList)
                {
                    oData.SP_InsertJoueur_Eqp(oJoueur.Id,eqp.Id);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        //désinscrire dans l'équipe envoyée en paramètre, la liste de joueurs envoyée en paramètre
        public void DesinscrireJoueurs_Eqp(List<MdlJoueurs> desinscriptJrsList, MdlEquipeChamp eqp)
        {
            try
            {
                EquipesData oData = new EquipesData();
                foreach (MdlJoueurs oJoueur in desinscriptJrsList)
                {
                    oData.SP_DeleteJoueur_Eqp(oJoueur.Id, eqp.Id);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        //vérifier le nb min de joueurs inscrits dans l'équipe, renvoit true si seuil pas atteint
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
                throw ex;
            }
        }

        //obtenir la liste des équipes remplissant les conditions de transfert vers une autre équipe
        public List<MdlEquipeChamp> GetEqpPouvantTransferer(int champ_id)
        {
            try
            {
                EquipesData oData = new EquipesData();
                List<SP_SelectEqpPlus5Joueurs_Ssn2_byChamp_Result> oResList =
                    oData.SP_SelectEqpPlus5Joueurs_Ssn2_byChamp(champ_id);
                List<MdlEquipeChamp> rtrnList = new List<MdlEquipeChamp>();
                foreach (SP_SelectEqpPlus5Joueurs_Ssn2_byChamp_Result eqp in oResList)
                {
                    MdlEquipeChamp oEqp = new MdlEquipeChamp();
                    oEqp.Id = eqp.EqpId;
                    oEqp.Nom = eqp.Eqp_Nom;

                    rtrnList.Add(oEqp);
                }

                return rtrnList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //obtenir la liste des équipes remplissant les conditions pour recevoir un joueur lors d'un transfert depuis une autre équipe
        public List<MdlEquipeChamp> GetEqpPouvantRecevoirTrnsfrt(int champ_id)
        {
            try
            {
                //l'équipe doit être dans les 3 dernières du classement
                ClassementServices oClassmntServices = new ClassementServices();
                //prendre le classement du championnat
                List<MdlClassement> oClassement = oClassmntServices.GetClassement(champ_id);
                //créer une liste recevant les équipes dans les 3 dernières positions du classement
                List<MdlEquipeChamp> eqpList = new List<MdlEquipeChamp>();
                //prendre le dernier index de la liste
                int indexLastEqp = (oClassement.Count) - 1;
                //parcourir la liste du classement par la fin, pour prendre les 3 dernières équipes
                for (int i = 0; i < 3 && indexLastEqp >= 0; i++, indexLastEqp--)
                {
                    MdlEquipeChamp oEqp = new MdlEquipeChamp();
                    oEqp.Id = oClassement[indexLastEqp].EquipeID;
                    oEqp.Nom = oClassement[indexLastEqp].EquipeNom;
                    eqpList.Add(oEqp);
                }

                //vérifier qu'il n'y a pas d'égalité de points entre la dernière équipe -2 et sa/ses précédentes
                //si oui, les ajouter à la liste car elles sont à la même position du classement
                if ((indexLastEqp >= 0) && (oClassement[indexLastEqp].Points == oClassement[indexLastEqp + 1].Points))
                {
                    while ((indexLastEqp >= 0) &&
                           (oClassement[indexLastEqp].Points == oClassement[indexLastEqp + 1].Points))
                    {
                        MdlEquipeChamp oEqp = new MdlEquipeChamp();
                        oEqp.Id = oClassement[indexLastEqp].EquipeID;
                        oEqp.Nom = oClassement[indexLastEqp].EquipeNom;
                        eqpList.Add(oEqp);
                        indexLastEqp--;
                    }
                }

                return eqpList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
