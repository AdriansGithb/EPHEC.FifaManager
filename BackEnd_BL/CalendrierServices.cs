using Models;
using BackEnd_DAL;
using Errors;
using System;
using System.CodeDom;
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
        public bool GnrPossible(out int blckdSsn, int champ_id, int slctdSsn)
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
                    oMatchClndr.Saison_Id = match.Mch_Ssn_ID;
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
                    if (match.Date is null)
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

        //création d'une liste de matchs pour la saison 1
        public List<MdlMatchClndr> CreateMatchs_FirstSsn(int ssn1_id)
        {
            try
            {
                List<MdlEquipeClndr> eqpList = GetEqpList(ssn1_id);
                List<MdlMatchClndr> matchList = new List<MdlMatchClndr>();
                int nbEqp = eqpList.Count;

                for (int dom = 0; dom < (nbEqp - 1); dom++)
                {
                    for (int vst = dom + 1; vst < nbEqp; vst++)
                    {
                        MdlMatchClndr nwMatch = new MdlMatchClndr();
                        nwMatch.EqpDom_CoChmp_ID = eqpList[dom].Id;
                        nwMatch.Nom_EqpDom = eqpList[dom].Nom;
                        nwMatch.EqpVisit_CoChmp_ID = eqpList[vst].Id;
                        nwMatch.Nom_EqpVisit = eqpList[vst].Nom;
                        nwMatch.Saison_Id = ssn1_id;

                        matchList.Add(nwMatch);
                    }
                }

                return matchList;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //création d'une liste de matchs pour la saison 2
        public List<MdlMatchClndr> CreateMatchs_SecondSsn(int ssn2_id)
        {
            try
            {
                List<MdlEquipeClndr> eqpList = GetEqpList(ssn2_id);
                List<MdlMatchClndr> matchList = new List<MdlMatchClndr>();
                int nbEqp = eqpList.Count;

                for (int dom = (nbEqp - 1); dom > 0 ; dom--)
                {
                    for (int vst = 0 ; vst < dom; vst++)
                    {
                        MdlMatchClndr nwMatch = new MdlMatchClndr();
                        nwMatch.EqpDom_CoChmp_ID = eqpList[dom].Id;
                        nwMatch.Nom_EqpDom = eqpList[dom].Nom;
                        nwMatch.EqpVisit_CoChmp_ID = eqpList[vst].Id;
                        nwMatch.Nom_EqpVisit = eqpList[vst].Nom;
                        nwMatch.Saison_Id = ssn2_id;

                        matchList.Add(nwMatch);
                    }
                }

                return matchList;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //génération d'une liste comprenant les week-end de la saison
        public List<DateTime> CreateSsnDateList_Ssn(DateTime beginDate)
        {
            try
            {
                DateTime EndDate = GetEndSsnDate(beginDate);
                List<DateTime> rtrnLst = new List<DateTime>();
                for (DateTime begin = beginDate; EndDate.CompareTo(begin)>=0; begin=begin.AddDays(1))
                {
                    if(begin.DayOfWeek==DayOfWeek.Saturday||begin.DayOfWeek==DayOfWeek.Sunday)
                        rtrnLst.Add(begin);
                }

                return rtrnLst;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //attribution aléatoire de dates pour une liste de matchs
        public List<MdlMatchClndr> GenererDates_MatchsListe(List<MdlMatchClndr> matchLst, List<DateTime> datesPossibles)
        {
            try
            {
                //calcul du nombre de matchs max possible par w-e
                int nbEqp = (matchLst.GroupBy(match => match.EqpDom_CoChmp_ID).ToList().Count)+1;
                int maxMatchPerDay = nbEqp / 2;
                //initiation des variables utiles
                int indexDatPoss = 0;
                List<DateTime> lstDatePerWE = new List<DateTime>();
                List<MdlMatchClndr> rtrnMatchList = new List<MdlMatchClndr>();
                List<MdlMatchClndr> tempMatchList = new List<MdlMatchClndr>();
                MdlMatchClndr tempMatch = new MdlMatchClndr();
                int slctdDateIndex;
                int slctdMatchIndex;
                Random tirage = new Random();
                //boucle dans la liste des dates
                while ((indexDatPoss < datesPossibles.Count) && (matchLst.Count > 0))
                {
                    //vérification si la 1ere date est un dimanche, ou si c'est la dernière de la liste :
                    //si oui, une seule date est possible pour cette insertion,
                    //si non, on insère 2 dates
                    if ((datesPossibles[indexDatPoss].DayOfWeek == DayOfWeek.Sunday)||(indexDatPoss==(datesPossibles.Count-1)))
                    {
                        lstDatePerWE.Add(datesPossibles[indexDatPoss]);
                        indexDatPoss += 1;
                    }
                    else
                    {
                        lstDatePerWE.Add(datesPossibles[indexDatPoss]);
                        lstDatePerWE.Add(datesPossibles[(indexDatPoss+1)]);
                        indexDatPoss += 2;
                    }
                    //boucle d'insertion aléatoire des matchs : choix de date aléatoire entre les 2 jours de WE et choix de match aléatoire dans la liste de matchs restants
                    for (int i = 0; (i < maxMatchPerDay) && (matchLst.Count > 0);)
                    {
                        slctdDateIndex = tirage.Next(0, lstDatePerWE.Count);
                        slctdMatchIndex = tirage.Next(0, matchLst.Count);
                        tempMatch = matchLst[slctdMatchIndex];
                        //si la liste est vide ou si l'id d'une équipe du match sélectionné n'est pas déjà présente dans la liste du week-end, insérer le match
                        if ((tempMatchList.Count == 0) || (tempMatchList.FindIndex(match =>
                                                               match.EqpDom_CoChmp_ID ==
                                                               tempMatch.EqpDom_CoChmp_ID ||
                                                               match.EqpDom_CoChmp_ID ==
                                                               tempMatch.EqpVisit_CoChmp_ID ||
                                                               match.EqpVisit_CoChmp_ID ==
                                                               tempMatch.EqpDom_CoChmp_ID ||
                                                               match.EqpVisit_CoChmp_ID ==
                                                               tempMatch.EqpVisit_CoChmp_ID) == -1))
                        {
                            tempMatch.Date = lstDatePerWE[slctdDateIndex];
                            tempMatchList.Add(tempMatch);
                            matchLst.RemoveAt(slctdMatchIndex);
                            i++;
                        }
                    }
                    //insérer la liste du week-end dans la liste complète à retourner
                    rtrnMatchList.AddRange(tempMatchList);
                    tempMatchList.Clear();                            
                    lstDatePerWE.Clear();

                }
                //une fois le passage en boucles fini, si il reste des matchs non insérés, s'assurer que leur date est vide, et insérer ces matchs dans la liste retour
                if (matchLst.Count > 0)
                {
                    foreach (MdlMatchClndr match in matchLst)
                    {
                        match.Date=null;
                    }
                    rtrnMatchList.AddRange(matchLst);
                }
                return rtrnMatchList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //fonction générant un calendrier pour 1 saison donnée en paramètre
        public List<MdlMatchClndr> GenererCalendrier_Saison(MdlSaison ssn)
        {
            try
            {
                List<MdlMatchClndr> undatedMatchList = new List<MdlMatchClndr>();
                if (ssn.FirstOrSecond == 1)
                    undatedMatchList = CreateMatchs_FirstSsn(ssn.Id);
                else
                    undatedMatchList = CreateMatchs_SecondSsn(ssn.Id);
                List<DateTime> lstPossibleDates = CreateSsnDateList_Ssn(ssn.Debut);
                List<MdlMatchClndr> datedMatchList = new List<MdlMatchClndr>();
                datedMatchList=GenererDates_MatchsListe(undatedMatchList,lstPossibleDates);

                return datedMatchList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //régénérer un calendrier qui avait déjà été généré précédemment et enregistré dans la BD
        public List<MdlMatchClndr> RegenererCalendrier_Saison(MdlSaison ssn,List<MdlMatchClndr> oldClndr)
        {
            try
            {
                List<DateTime> lstPossibleDates = CreateSsnDateList_Ssn(ssn.Debut);
                List<MdlMatchClndr> datedMatchList = new List<MdlMatchClndr>();
                datedMatchList=GenererDates_MatchsListe(oldClndr, lstPossibleDates);

                return datedMatchList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //fonction générant un calendrier pour les 2 saisons
        public List<MdlMatchClndr> GenererCalendrier_2Saisons(List<MdlSaison> ssnList)
        {
            try
            {
                List<MdlMatchClndr> fullList = new List<MdlMatchClndr>();
                fullList = GenererCalendrier_Saison(ssnList[0]);
                fullList.AddRange(GenererCalendrier_Saison(ssnList[1]));
                return fullList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //fonction permettant d'envoyer une liste de matchs dans la BD
        public void InsertUpdate_MtchClndr(List<MdlMatchClndr> mchList)
        {
            try
            {
                CalendrierData oData = new CalendrierData();
                foreach (MdlMatchClndr match in mchList)
                {
                    oData.SP_InsertUpdateMtchClndr(match.Match_ID,match.Date,match.Saison_Id,match.EqpDom_CoChmp_ID, match.EqpVisit_CoChmp_ID, match.LastUpdate);
                }
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

        //fonction permettant de mettre à jour la date de génération de calendrier
        public void SetDateGnrClndr_Ssn(int ssn_id)
        {
            CalendrierData oData = new CalendrierData();
            oData.SP_SetDateGnrClndr_Ssn(ssn_id);
        }

        //obtenir la date de fin d'une saison
        public DateTime GetEndSsnDate(DateTime beginDate)
        {
            DateTime EndDate = beginDate.AddDays(MdlChampionnat.SsnWeeks * 7);
            return EndDate;
        }
    }
}
