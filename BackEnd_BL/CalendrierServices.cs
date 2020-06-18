using Models;
using BackEnd_DAL;
using Errors;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
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
        //fonction pour vérifier la possibilité ou non de générer/modifier le calendrier du championnat sélectionné
        public bool GnrPossible(out int blckdSsn, int champ_id, int slctdSsn)
        {
            try
            {
                bool possible = false;
                blckdSsn = -1;
                //récupération des saisons du championnats sélectionné
                ChampionnatsServices oServices = new ChampionnatsServices();
                List<MdlSaison> lstSsnChamp = oServices.GetChampSaisons(champ_id);
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //fonction de préparation des données pour les tableaux calendrier, qui renvoit 2 listes dans une liste
        public List<List<MdlMatchClndr>> GetClndrLists(int champ_id, int slctdSsn)
        {
            try
            {
                List<SP_SelectCalendrier_Result> clndrBdList = new List<SP_SelectCalendrier_Result>();
                ChampionnatsServices oServices = new ChampionnatsServices();
                List<MdlSaison> oSsnLst = oServices.GetChampSaisons(champ_id);
                List<MdlMatchClndr> fullMatchList = new List<MdlMatchClndr>();
                //chargement des listes de matchs en fonction de la saison sélectionnée
                CalendrierData oData = new CalendrierData();
                //si seule la saison 1 ou 2 est demandée
                if (slctdSsn == 1 || slctdSsn == 2)
                {
                    MdlSaison oSsn = oSsnLst.Find(ssn => ssn.FirstOrSecond == slctdSsn);
                    clndrBdList = oData.SelectCalendrier(oSsn.Id);
                }
                //sinon (les 2 saisons sont demandées)
                else
                {
                    MdlSaison oSsn = oSsnLst.Find(ssn => ssn.FirstOrSecond == 1);
                    clndrBdList = oData.SelectCalendrier(oSsn.Id);
                    oSsn = oSsnLst.Find(ssn => ssn.FirstOrSecond == 2);
                    clndrBdList.AddRange(oData.SelectCalendrier(oSsn.Id));
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //création d'une liste de matchs pour la saison 1
        public List<MdlMatchClndr> CreateMatchs_FirstSsn(int ssn1_id)
        {
            try
            {
                ChampionnatsServices oServices = new ChampionnatsServices();
                List<MdlEquipeChamp> eqpList = oServices.GetEqpList_bySsn(ssn1_id);
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }

        //création d'une liste de matchs pour la saison 2
        public List<MdlMatchClndr> CreateMatchs_SecondSsn(int ssn2_id)
        {
            try
            {
                ChampionnatsServices oServices = new ChampionnatsServices();
                List<MdlEquipeChamp> eqpList = oServices.GetEqpList_bySsn(ssn2_id);
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
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

                    bool sortie = false;
                    //boucle d'insertion aléatoire des matchs : choix de date aléatoire entre les 2 jours de WE et choix de match aléatoire dans la liste de matchs restants
                    //boucle par un w-e de la liste des dates possibles
                    for (int max = 0; (tempMatchList.Count < maxMatchPerDay) && (matchLst.Count > 0) && (sortie==false);)
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
                            max = 0;
                        }
                        //sinon, augmenter le compteur max (qui permet de vérifier qu'on n'entre pas dans une boucle infinie car aucun match ne rentre dans les conditions de remplissage)
                        else
                        {
                            max++;
                            //si max équivaut au nb de match sans dates restants : parcourir toute la liste restante un par un
                            //afin de vérifier si un match peut encore être inséré
                            if (max == matchLst.Count)
                            {
                                //sortir si le parcours de la liste ne permet pas de trouver un match respectant les conditions
                                sortie = true;
                                for (int j = 0; (j < matchLst.Count)&&(sortie==true); j++)
                                {
                                    tempMatch = matchLst[j];
                                    //si un match de la liste des matchs à insérer peut encore entrer dans le calendrier en respectant les conditions
                                    if (tempMatchList.FindIndex(match =>
                                            match.EqpDom_CoChmp_ID ==
                                            tempMatch.EqpDom_CoChmp_ID ||
                                            match.EqpDom_CoChmp_ID ==
                                            tempMatch.EqpVisit_CoChmp_ID ||
                                            match.EqpVisit_CoChmp_ID ==
                                            tempMatch.EqpDom_CoChmp_ID ||
                                            match.EqpVisit_CoChmp_ID ==
                                            tempMatch.EqpVisit_CoChmp_ID) == -1)
                                    {
                                        //alors ne pas sortir, insérer le match dans le calendrier auto, incrémenter i (compteur de la liste temp)
                                        tempMatch.Date = lstDatePerWE[slctdDateIndex];
                                        tempMatchList.Add(tempMatch);
                                        matchLst.RemoveAt(j);
                                        sortie = false;                                
                                        max = 0;
                                    }
                                }                                        
                            }
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
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
            catch (BusinessErrors ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
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
                    oData.InsertUpdateMtchClndr(match.Match_ID,match.Date,match.Saison_Id,match.EqpDom_CoChmp_ID, match.EqpVisit_CoChmp_ID, match.LastUpdate);
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

        //fonction permettant de mettre à jour la date de génération de calendrier
        public void SetDateGnrClndr_Ssn(int ssn_id)
        {
            try
            {
                CalendrierData oData = new CalendrierData();
                oData.SetDateGnrClndr_Ssn(ssn_id);
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

        //obtenir la date de fin d'une saison
        public DateTime GetEndSsnDate(DateTime beginDate)
        {
            try
            {
                DateTime EndDate = beginDate.AddDays(MdlChampionnat.SsnWeeks * 7);
                return EndDate;
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

        //savoir si une date est sélectionnable pour un match
        public bool SelectedDateMatchPossible(DateTime slctdDate, MdlMatchClndr slctdMatch)
        {
            try
            {
                CalendrierData oData = new CalendrierData();
                List<SP_CheckDateMatchPossible_Result>resList = oData.CheckDateMatchPossible(slctdDate, slctdMatch.EqpDom_CoChmp_ID, slctdMatch.EqpVisit_CoChmp_ID);
                if (resList.Count > 0)
                    return false;
                else return true;
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
