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
    
    public partial class Events
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Events()
        {
            this.Suspensions = new HashSet<Suspensions>();
        }
    
        public int Evnt_ID { get; set; }
        public int Evnt_IMch_ID { get; set; }
        public int Evnt_Mch_ID { get; set; }
        public int Evnt_TEvnt_ID { get; set; }
    
        public virtual Inscription_Matchs Inscription_Matchs { get; set; }
        public virtual Matchs Matchs { get; set; }
        public virtual Types_Events Types_Events { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suspensions> Suspensions { get; set; }
    }
}
