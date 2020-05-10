﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd_DAL;
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
            catch (Exception ex)
            {
                throw ex;
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
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
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
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
