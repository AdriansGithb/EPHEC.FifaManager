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
    public class ResultatsServices
    {
        //fonction appelant la DAL, pour obtenir et renvoyer les résultats sous forme de liste
        public List<MdlResultats> GetResultats(int champId,int ssn)
        {
            try
            {
                //appel de la DAL pour aller récupérer les données dans la BD
                ResultatsData oData = new ResultatsData();
                List<SP_SelectResults_Result> lstRes = oData.SelectResultats(champId, ssn);
                List<MdlResultats> rtrnList = new List<MdlResultats>();

                //inclure les résultats dans un format modèle lisible partout
                foreach (SP_SelectResults_Result res in lstRes)
                {
                    MdlResultats oRes = new MdlResultats();
                    oRes.Match_ID = res.Match_ID;
                    oRes.Date = res.Date;
                    oRes.Nom_EqpDom = res.Equipe_Domicile;
                    oRes.Nom_EqpVisit = res.Equipe_Visiteuse;
                    oRes.ResultDom = res.Resultat_Domicile;
                    oRes.ResDomTypeID = res.TypeResultIDDomicile;
                    oRes.ResultVisit = res.Resultat_Visiteur;
                    oRes.ResVstTypeID = res.TypeResultIDVisiteur;
                    oRes.LastUpdate = res.Mch_LastUpdate;

                    rtrnList.Add(oRes);
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

        //fonction appelant la DAL, pour obtenir et renvoyer la liste des types de résultats dispos dans la BD
        public List<MdlTypeResult> GetTypeResults()
        {
            try
            {
                //appel de la DAL pour aller récupérer les données dans la BD
                ResultatsData oData = new ResultatsData();
                List<SP_SelectAllTypeResults_Result> lstTpRes = oData.SelectAllTypeResults();
                List<MdlTypeResult> rtrnLst = new List<MdlTypeResult>();

                //inclure les résultats dans un format modèle lisible partout
                foreach (SP_SelectAllTypeResults_Result tpRes in lstTpRes)
                {
                    MdlTypeResult oTpRes = new MdlTypeResult();
                    oTpRes.Id = tpRes.Res_ID;
                    oTpRes.Libelle = tpRes.Res_Libelle;

                    rtrnLst.Add(oTpRes);
                }

                return rtrnLst;
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

        //méthode permettant d'envoyer les nouveaux résultats dans la BD, via la DAL
        public void SetResultat(int mchId, int newResDom, int newResVst, DateTime lstUpdt)
        {
            try
            {
                ResultatsData oData = new ResultatsData();
                oData.ModifResult(mchId, newResDom, newResVst, lstUpdt);
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
