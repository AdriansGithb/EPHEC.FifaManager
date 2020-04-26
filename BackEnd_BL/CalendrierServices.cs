using Models;
using BackEnd_DAL;
using Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SP_SelectCalendrier_Result = BackEnd_DAL.SP_SelectCalendrier_Result;

namespace BackEnd_BL
{
    public class CalendrierServices
    {
        //fonction permettant d'appeler la DAL pour obtenir les 2 saisons d'un championnat déterminé
        public List<MdlSaison> GetChampSaisons(int champ_id)
        {
            try
            {
                //appel de la procédure via la DAL
                CalendrierData oData = new CalendrierData();
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

        //fonction pour vérifier la possibilité ou non de générer/modifier le calendrier du championnat sélectionné
        public bool GnrPossible(out int blckdSsn,int champ_id, int slctdSsn)
        {
            try
            {
                bool possible = false;
                blckdSsn = -1;
                //récupération des saisons du championnats sélectionné
                List<MdlSaison> lstSsnChamp = GetChampSaisons(champ_id);
                //si une seule saison est sélectionnée
                if (slctdSsn != 12)
                {
                    MdlSaison oSsn = lstSsnChamp.Find(ssn => ssn.FirstOrSecond == slctdSsn);
                    if (oSsn.Debut > DateTime.Now)
                        possible = true;
                    else
                        blckdSsn = slctdSsn;
                }
                //si les 2 saisons sont sélectionnées
                else
                {
                    MdlSaison oSsn1 = lstSsnChamp.Find(ssn => ssn.FirstOrSecond == 1);
                    MdlSaison oSsn2 = lstSsnChamp.Find(ssn => ssn.FirstOrSecond == 2);
                    //si les 2 saisons n'ont pas commencé
                    if ((oSsn1.Debut > DateTime.Today) && (oSsn2.Debut > DateTime.Today))
                        possible = true;
                    //sinon, si les 2 saisons ont commencé
                    else if ((oSsn1.Debut <= DateTime.Today) && (oSsn2.Debut <= DateTime.Today))
                        blckdSsn = 12;
                        //throw new Exception("Les 2 saisons ont commencé");
                    //sinon, si seule la saison 1 a commencé
                    else if (oSsn1.Debut <= DateTime.Today)
                        blckdSsn = 1;
                        //throw new Exception("Seule la saison 1 a commencé");
                    else
                        throw new Exception("Seule la saison 2 a commencé");
                }

                return possible;
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

        //fonction de préparation des données pour les tableaux calendrier, qui renvoit 2 listes dans une liste
        public List<List<MdlMatchClndr>> GetClndrLists(int champ_id, int slctdSsn)
        {
            try
            {
                List<SP_SelectCalendrier_Result> clndrBdList = new List<SP_SelectCalendrier_Result>();
                List<MdlSaison> oSsnLst = GetChampSaisons(champ_id);
                List<MdlMatchClndr> fullMatchList = new List<MdlMatchClndr>();
                //chargement des listes de matchs en fonction de la saison sélectionnée
                CalendrierData oData = new CalendrierData();
                //si seule la saison 1 ou 2 est demandée
                if (slctdSsn == 1 || slctdSsn == 2)
                {
                    MdlSaison oSsn = oSsnLst.Find(ssn => ssn.FirstOrSecond == slctdSsn);
                    clndrBdList = oData.SP_SelectCalendrier(oSsn.Id);
                }
                //sinon (les 2 saisons sont demandées)
                else
                {
                    MdlSaison oSsn = oSsnLst.Find(ssn => ssn.FirstOrSecond == 1);
                    clndrBdList = oData.SP_SelectCalendrier(oSsn.Id);
                    oSsn = oSsnLst.Find(ssn => ssn.FirstOrSecond == 2);
                    clndrBdList.AddRange(oData.SP_SelectCalendrier(oSsn.Id));
                }
                //transformation des objets en MdlMatchClndr
                foreach (SP_SelectCalendrier_Result match in clndrBdList)
                {
                    MdlMatchClndr oMatchClndr = new MdlMatchClndr();
                    oMatchClndr.Match_ID = match.Mch_ID;
                    oMatchClndr.Date = match.Mch_Date;
                    oMatchClndr.EqpDom_CoChmp_ID = match.Mch_Eqp_Dom_ID;
                    oMatchClndr.Nom_EqpDom = match.EqpDom_Nom;
                    oMatchClndr.EqpVisit_CoChmp_ID = match.Mch_Eqp_Visit_ID;
                    oMatchClndr.Nom_EqpVisit = match.EqpVst_Nom;
                    oMatchClndr.LastUpdate = match.Mch_LastUpdate;

                    fullMatchList.Add(oMatchClndr);
                }
                //division de la liste en 2 listes : matchs avec ou sans date
                List<MdlMatchClndr> datedMatchList = new List<MdlMatchClndr>();
                List<MdlMatchClndr> undatedMatchList = new List<MdlMatchClndr>();

                foreach (MdlMatchClndr match in fullMatchList)
                {
                    if(match.Date is null)
                        undatedMatchList.Add(match);
                    else datedMatchList.Add(match);
                }
                //renvoi des listes
                List<List<MdlMatchClndr>> rtrnList = new List<List<MdlMatchClndr>>();
                rtrnList.Add(datedMatchList);
                rtrnList.Add(undatedMatchList);

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
        public List<MdlEquipeClndr> GetEqpList(int ssn_id)
        {
            try
            {
                CalendrierData oData = new CalendrierData();
                List<SP_SelectEqpPerSsn_Result> eqpList = oData.SP_SelectEqpPerSsn(ssn_id);
                List<MdlEquipeClndr> rtrnList = new List<MdlEquipeClndr>();
                foreach (SP_SelectEqpPerSsn_Result eqp in eqpList)
                {
                    MdlEquipeClndr oEqp = new MdlEquipeClndr();
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

        //fonction générant des calendriers
        public List<MdlMatchClndr> GenererCalendrier(List<MdlSaison> lstSsnChamp, int slctdSsn)
        {
            try
            {
                return new List<MdlMatchClndr>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
