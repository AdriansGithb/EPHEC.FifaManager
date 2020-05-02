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

        //fonction permettant d'appeler la DAL pour obtenir les 2 saisons d'un championnat déterminé
        public List<MdlSaison> GetChampSaisons(int champ_id)
        {
            try
            {
                //appel de la procédure via la DAL
                ChampionnatsData oData = new ChampionnatsData();
                List<Saisons> lstSsn = oData.SP_SelectAllSsn1Champ(champ_id);
                //insertion des résultats dans une liste
                List<MdlSaison> rtrnLst = new List<MdlSaison>();
                foreach (Saisons ssn in lstSsn)
                {
                    MdlSaison oSsn = new MdlSaison();
                    oSsn.Id = ssn.Ssn_ID;
                    oSsn.Champ_Id = ssn.Ssn_Champ_ID;
                    oSsn.Debut = ssn.Ssn_Date_Debut;
                    oSsn.FirstOrSecond = ssn.Ssn_Num;
                    oSsn.GnrClndr = ssn.Ssn_Date_Gnr_Clndr;

                    rtrnLst.Add(oSsn);
                }

                return rtrnLst;
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

        //récupération de la liste d'équipes inscrites à une saison donnée en paramètre
        public List<MdlEquipeChamp> GetEqpList_bySsn(int ssn_id)
        {
            try
            {
                ChampionnatsData oData = new ChampionnatsData();
                List<SP_SelectEqpPerSsn_Result> eqpList = oData.SP_SelectEqpPerSsn(ssn_id);
                List<MdlEquipeChamp> rtrnList = new List<MdlEquipeChamp>();
                foreach (SP_SelectEqpPerSsn_Result eqp in eqpList)
                {
                    MdlEquipeChamp oEqp = new MdlEquipeChamp();
                    oEqp.Id = eqp.CoChmp_ID;
                    oEqp.Nom = eqp.Eqp_Nom;

                    rtrnList.Add(oEqp);
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

        //récupération de la liste d'équipes inscrites à une saison donnée en paramètre
        public List<MdlEquipeChamp> GetEqpList_byChamp(int champ_id)
        {
            try
            {
                ChampionnatsData oData = new ChampionnatsData();
                List<SP_SelectEqpPerChamp_Result> eqpList = oData.SP_SelectEqpPerChamp(champ_id);
                List<MdlEquipeChamp> rtrnList = new List<MdlEquipeChamp>();
                foreach (SP_SelectEqpPerChamp_Result eqp in eqpList)
                {
                    MdlEquipeChamp oEqp = new MdlEquipeChamp();
                    oEqp.Id = eqp.CoChmp_ID;
                    oEqp.Nom = eqp.Eqp_Nom;

                    rtrnList.Add(oEqp);
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

        // obtenir la liste des championnats non débutés
        public List<MdlChampionnat> GetNotStartedChampionnats()
        {
            try
            {
                //création liste avec tous les championnats
                List<MdlChampionnat> allChampList = GetChampionnats();
                //et d'une liste à renvoyer qui recevra tous les championnats dont la date de début de 1ere saison n'a pas été dépassée
                List<MdlChampionnat> rtrnList = new List<MdlChampionnat>();
                //pour chaque championnat, vérifier si la date de début de 1e saison est antérieure à aujourd'hui
                foreach (MdlChampionnat champ in allChampList)
                {
                    List<MdlSaison> ssnList = GetChampSaisons(champ.Id);
                    MdlSaison frstSsn = ssnList.Find(ssn => ssn.FirstOrSecond == 1);
                    //si la date est postérieure à aujourd'hui,ajouter le championnat dans la liste à retourner
                    if(frstSsn.Debut>DateTime.Today)
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
