using BackEnd_DAL;
using Errors;
using Models;
using System;
using System.Collections.Generic;
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
            catch (Exception ex)
            {
                throw new BusinessErrors(ex.Message);
            }
        }
    }
}
