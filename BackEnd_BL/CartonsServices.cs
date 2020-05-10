using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd_DAL;
using Models;

namespace BackEnd_BL
{
    public class CartonsServices
    {
        //renvoyer la liste des différents types de cartons
        public List<MdlTypeCarton> GetAllTypesCartons()
        {
            try
            {
                CartonsData oData = new CartonsData();
                List<SP_SelectAllTypeCartons_Result> rcvdList = oData.SelectAllTypeCartons();
                List<MdlTypeCarton> rtrnList = new List<MdlTypeCarton>();
                foreach (SP_SelectAllTypeCartons_Result type in rcvdList)
                {
                    MdlTypeCarton oTypCart = new MdlTypeCarton();
                    oTypCart.Id = type.TEvnt_ID;
                    oTypCart.Libelle = type.TEvnt_Libelle;

                    rtrnList.Add(oTypCart);
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
