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
    
    public partial class SP_HistoriqueJoueur_Result
    {
        public string Championnat { get; set; }
        public int Saison { get; set; }
        public string Equipe_Joueur { get; set; }
        public int Match_ID { get; set; }
        public Nullable<System.DateTime> Match_Date { get; set; }
        public string Resultat { get; set; }
        public string Equipe_Adverse { get; set; }
    }
}
