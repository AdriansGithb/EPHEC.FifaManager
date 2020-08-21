using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BackEnd_DAL;
using Errors;
using Models;

namespace BackEnd_BL
{
    public class CartonsServices
    {
        //renvoyer la liste des différents types de cartons
        public List<MdlTypeCarton> GetAllTypesCartons()
        {
            try
            {
                CartonsData oData = new CartonsData();
                List<SP_SelectAllTypeCartons_Result> rcvdList = oData.SelectAllTypeCartons();
                List<MdlTypeCarton> rtrnList = new List<MdlTypeCarton>();
                foreach (SP_SelectAllTypeCartons_Result type in rcvdList)
                {
                    MdlTypeCarton oTypCart = new MdlTypeCarton();
                    oTypCart.Id = type.TEvnt_ID;
                    oTypCart.Libelle = type.TEvnt_Libelle;

                    rtrnList.Add(oTypCart);
                }

                return rtrnList;
            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //renvoyer la liste de tous les cartons
        public List<MdlCartons> GetAllCartons()
        {
            try
            {
                CartonsData oData = new CartonsData();
                List<SP_SelectAllCartons_Result> rcvdList = oData.SelectAllCartons();
                List<MdlCartons> rtrnList = new List<MdlCartons>();
                //transformer les objets en modèles
                foreach (SP_SelectAllCartons_Result cart in rcvdList)
                {
                    MdlCartons oCarton = new MdlCartons();
                    oCarton.Championnat = cart.Championnat;
                    oCarton.Carton_ID = cart.Carton_ID;
                    oCarton.Couleur = cart.Carton_Type;
                    //création d'un string pour le joueur
                    oCarton.Joueur = $"{cart.Jr_Nom} {cart.Jr_Prenom} -{cart.Jr_ID}-";
                    oCarton.MatchID_Event = cart.MatchID_Event;
                    //personnalisation du champ match suspendu : si ID_MatchSuspendus est null c'est que la suspension n'a pas été effectuée, sinon enregistrer l'id du match de suspension
                    if (cart.MatchID_Suspension_effectuée is null)
                        oCarton.ID_MatchSuspendus = "Pas effectué";
                    else oCarton.ID_MatchSuspendus = cart.MatchID_Suspension_effectuée.ToString();

                    rtrnList.Add(oCarton);
                }

                return rtrnList;
            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //filtrer la liste des cartons selon la sélection dans la form
        public List<MdlCartons> ExecuteFilters(MdlChampionnat oChamp, MdlTypeCarton oCartType, List<MdlCartons> fullCartList)
        {
            try
            {
                List<MdlCartons> champFltrdList = new List<MdlCartons>();
                List<MdlCartons> rtrnList = new List<MdlCartons>();
                //si on a filtré les championnats
                if (oChamp.Id != -1)
                {
                    foreach (MdlCartons oCart in fullCartList)
                    {
                        if(oChamp.Nom==oCart.Championnat)
                            champFltrdList.Add(oCart);
                    }
                }
                //sinon insérer la fulllist dans la liste filtrée
                else champFltrdList.AddRange(fullCartList);
                //ensuite, appliquer le filtre de couleur et ajouter les résultats filtrés dans la liste à retourner
                if (oCartType.Id != -1)
                {                
                    //si on a filtré la couleur du carton
                    //filtrer et insérer chaque résultat correspondant dans la liste de retour
                    foreach (MdlCartons oCart in champFltrdList)
                    {
                        //si le carton a la bonne couleur, l'insérer dans la liste à retourner
                        if (oCartType.Libelle == oCart.Couleur)
                            rtrnList.Add(oCart);
                    }
                }
                //si on n'a pas appliqué de filtre sur la couleur du carton, renvoyer la liste trié précédemment par championnat
                else rtrnList.AddRange(champFltrdList);

                return rtrnList;
            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //renvoyer la liste filtrée des cartons
        public List<MdlCartons> GetFilteredCartonsList(MdlChampionnat oChamp, MdlTypeCarton oCartType)
        {
            try
            {
                List<MdlCartons> fullList = GetAllCartons();
                //si les filtres sélectionnés = tous les championnats et tous les types de cartes
                //renvoyer la liste complète, sans filtre
                if (oChamp.Id == -1 && oCartType.Id == -1)
                    return fullList;
                //sinon, renvoyer une liste filtrée
                else
                {
                    List<MdlCartons> rtrnList = ExecuteFilters(oChamp, oCartType, fullList);
                    return rtrnList;
                }
            }
            catch (BusinessErrors )
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }
    }
}
