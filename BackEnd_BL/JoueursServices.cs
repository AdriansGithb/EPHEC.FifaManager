using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd_DAL;
using Errors;
using Models;

namespace BackEnd_BL
{
    public class JoueursServices
    {
        //transformation Joueurs en MdlJoueurs
        public List<MdlJoueurs> ToMdlJoueurs(List<Joueurs> jrList)
        {
            try
            {
                List<MdlJoueurs> rtrnList = new List<MdlJoueurs>();
                foreach (Joueurs joueur in jrList)
                {
                    MdlJoueurs oMdlJoueurs = new MdlJoueurs(joueur.Jr_ID, joueur.Jr_Nom, joueur.Jr_Prenom);
                    rtrnList.Add(oMdlJoueurs);
                }

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

        //obtenir la liste des joueurs non inscrits dans une équipe pour un championnat donné en paramètre
        public List<MdlJoueurs> GetJoueursDispo_byChamp(int champ_id)
        {
            try
            {
                JoueursData oData = new JoueursData();
                List<Joueurs> tempList = oData.SelectAllJoueursDispoByChamp(champ_id);
                List<MdlJoueurs> rtrnList = ToMdlJoueurs(tempList);
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

        //obtenir la liste des joueurs inscrits dans une équipe (donnée en paramètre) pour les 2 saisons d'un championnat 
        public List<MdlJoueurs> GetJoueursEqpList_AllSsn(int eqp_cochamp_id)
        {
            try
            {
                JoueursData oData = new JoueursData();
                List<Joueurs> tempList = oData.SelectAllJoueursByEqp(eqp_cochamp_id);
                List<MdlJoueurs> rtrnList = ToMdlJoueurs(tempList);
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

        //obtenir la liste des joueurs inscrits dans une équipe (donnée en paramètre) pour la 2e saison d'un championnat
        public List<MdlJoueursParEquipe> GetJoueursEqpList_Ssn2(int eqp_cochamp_id)
        {
            try
            {
                JoueursData oData = new JoueursData();
                List<SP_SelectAllJoueursByEqp_ForSsn2_Result> rcvdList =
                    oData.SelectAllJoueursByEqp_ForSsn2(eqp_cochamp_id);
                List<MdlJoueursParEquipe> rtrnList = new List<MdlJoueursParEquipe>();
                foreach (SP_SelectAllJoueursByEqp_ForSsn2_Result joueur in rcvdList)
                {
                    MdlJoueursParEquipe oJoueur = new MdlJoueursParEquipe(joueur.CEqp_ID,joueur.Jr_Nom,joueur.Jr_Prenom);
                    oJoueur.LastUpdate = joueur.CEqp_LastUpdate;

                    rtrnList.Add(oJoueur);
                }

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

        //obtenir la liste de tous les joueurs inscrits dans la BD
        public List<MdlJoueurs> GetAllJoueursList()
        {
            try
            {
                JoueursData oData = new JoueursData();
                List<Joueurs> rcvdList = oData.SelectAllJoueurs();
                List<MdlJoueurs> rtrnList = new List<MdlJoueurs>();
                foreach (Joueurs jr in rcvdList)
                {
                    MdlJoueurs oJoueur = new MdlJoueurs(jr.Jr_ID, jr.Jr_Nom, jr.Jr_Prenom);
                    rtrnList.Add(oJoueur);
                }

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

        //obtenir l'historique d'un joueur
        public List<MdlJoueurHistorique> GetHistorique_Joueur(MdlJoueurs slctdJoueur)
        {
            try
            {
                JoueursData oData = new JoueursData();
                List<SP_HistoriqueJoueur_Result> rcvdList = oData.SelectHistoriqueJoueur(slctdJoueur.Id);
                List<MdlJoueurHistorique> rtrnList = new List<MdlJoueurHistorique>();
                foreach (SP_HistoriqueJoueur_Result histJr in rcvdList)
                {
                    MdlJoueurHistorique oHist = new MdlJoueurHistorique();
                    oHist.Championnat = histJr.Championnat;
                    oHist.Saison=histJr.Saison;
                    oHist.Equipe_Joueur = histJr.Equipe_Joueur;
                    oHist.Match_ID = histJr.Match_ID;
                    oHist.Match_Date = histJr.Match_Date;
                    oHist.Resultat = histJr.Resultat;
                    oHist.Equipe_Adverse = histJr.Equipe_Adverse;

                    rtrnList.Add(oHist);
                }

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
    }
}
