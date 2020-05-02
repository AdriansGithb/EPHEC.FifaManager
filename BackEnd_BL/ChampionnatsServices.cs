using BackEnd_DAL;
using Errors;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_BL
{
    public class ChampionnatsServices
    {
        // obtenir la liste des championnats inscrits dans la BD
        public List<MdlChampionnat> GetChampionnats()
        {
            try
            {
                ChampionnatsData oData = new ChampionnatsData();
                List<Championnats> lstChamp = oData.SelectAllChampionnats().ToList();

                //tranformation en modèles MdlChampionnat
                List<MdlChampionnat> returnLst = new List<MdlChampionnat>();

                foreach (Championnats champ in lstChamp)
                {
                    MdlChampionnat oChamp = new MdlChampionnat(champ.Champ_ID, champ.Champ_Nom, champ.Champ_Annee);
                    //A SUPPRIMER SI OK POUR CONSTRUCTEUR
                    //oChamp.Id = champ.Champ_ID;
                    //oChamp.Nom = champ.Champ_Nom;
                    //oChamp.Annee = champ.Champ_Annee;

                    returnLst.Add(oChamp);
                }

                return returnLst;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // obtenir la liste des championnats non débutés
        public List<MdlChampionnat> GetNotStartedChampionnats()
        {
            try
            {
                //création liste avec tous les championnats
                List<MdlChampionnat> allChampList = GetChampionnats();
                //et d'une liste à renvoyer qui recevra tous les championnats dont la date de début de 1ere saison n'a pas été dépassée
                List<MdlChampionnat> rtrnList = new List<MdlChampionnat>();
                CalendrierData oData = new CalendrierData();
                //pour chaque championnat, vérifier si la date de début de 1e saison est antérieure à aujourd'hui
                foreach (MdlChampionnat champ in allChampList)
                {
                    List<Saisons> ssnList = oData.SP_SelectAllSsn1Champ(champ.Id);
                    Saisons frstSsn = ssnList.Find(ssn => ssn.Ssn_Num == 1);
                    //si la date est postérieure à aujourd'hui,ajouter le championnat dans la liste à retourner
                    if(frstSsn.Ssn_Date_Debut>DateTime.Today)
                        rtrnList.Add(champ);
                }

                return rtrnList;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
