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
    using System.Collections.Generic;
    
    public partial class Saisons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Saisons()
        {
            this.Constitution_Equipes = new HashSet<Constitution_Equipes>();
            this.Matchs = new HashSet<Matchs>();
        }
    
        public int Ssn_ID { get; set; }
        public int Ssn_Champ_ID { get; set; }
        public System.DateTime Ssn_Date_Debut { get; set; }
        public bool Ssn_Num { get; set; }
    
        public virtual Championnats Championnats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Constitution_Equipes> Constitution_Equipes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matchs> Matchs { get; set; }
    }
}
