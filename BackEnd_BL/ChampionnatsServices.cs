using BackEnd_DAL;
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
        public List<mdlChampionnat> GetChampionnats()
        {
            ChampionnatsData oData = new ChampionnatsData();
            List<Championnats> lstChamp = oData.SelectAllChampionnats().ToList();

            //tranformation en modèles
            List<mdlChampionnat> returnLst = new List<mdlChampionnat>();

            foreach (Championnats champ in lstChamp)
            {
                mdlChampionnat oChamp = new mdlChampionnat();
                oChamp.Id = champ.Champ_ID;
                oChamp.Nom = champ.Champ_Nom;
                oChamp.Annee = champ.Champ_Annee;

                returnLst.Add(oChamp);
            }

            return returnLst;
        }
    }
}
