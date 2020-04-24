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

namespace BackEnd_BL
{
    public class CalendrierServices
    {
        //méthode permettant d'appeler la DAL pour obtenir les 2 saisons d'un championnat déterminé
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

        //méthode pour vérifier la possibilité ou non de générer/modifier le calendrier du championnat sélectionné
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
    }
}
