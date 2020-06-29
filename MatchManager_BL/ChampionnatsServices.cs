using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;
using MatchManager_DAL;
using Models;

namespace MatchManager_BL
{
    public class ChampionnatsServices
    {
        // renvoit une liste contenant tous les championnats
        public List<MdlChampionnat> GetAllChampionnats()
        {
            try
            {
                List<MdlChampionnat> lstChamps = new List<MdlChampionnat>();
                ChampionnatsData oData = new ChampionnatsData();
                // réception de la datatable contenant les championnats
                DataTable oTab = oData.LoadData();
                DataTableReader oReader = oTab.CreateDataReader();
                // transformation des objets de la datatable en liste de modèles championnats
                while (oReader.Read())
                {
                    MdlChampionnat oChamp =
                        new MdlChampionnat(oReader.GetInt32(0), oReader.GetString(1), oReader.GetInt16(2));
                    lstChamps.Add(oChamp);
                }

                return lstChamps;
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
