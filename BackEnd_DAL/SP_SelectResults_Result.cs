//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd_DAL
{
    using System;
    
    public partial class SP_SelectResults_Result
    {
        public int Match_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Equipe_Domicile { get; set; }
        public string Equipe_Visiteuse { get; set; }
        public string Resultat_Domicile { get; set; }
        public int TypeResultIDDomicile { get; set; }
        public string Resultat_Visiteur { get; set; }
        public int TypeResultIDVisiteur { get; set; }
        public System.DateTime Mch_LastUpdate { get; set; }
    }
}
