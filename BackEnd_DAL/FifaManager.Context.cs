﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Fifa_ManagerEntities : DbContext
    {
        public Fifa_ManagerEntities()
            : base("name=Fifa_ManagerEntities")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Championnats> Championnats { get; set; }
        public virtual DbSet<Constitution_Championnat> Constitution_Championnat { get; set; }
        public virtual DbSet<Constitution_Equipes> Constitution_Equipes { get; set; }
        public virtual DbSet<Equipes> Equipes { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Inscription_Matchs> Inscription_Matchs { get; set; }
        public virtual DbSet<Joueurs> Joueurs { get; set; }
        public virtual DbSet<Matchs> Matchs { get; set; }
        public virtual DbSet<Saisons> Saisons { get; set; }
        public virtual DbSet<Suspensions> Suspensions { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Types_Events> Types_Events { get; set; }
        public virtual DbSet<Types_Resultats> Types_Resultats { get; set; }
    
        public virtual ObjectResult<Championnats> SP_SelectAllChampionnats()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Championnats>("SP_SelectAllChampionnats");
        }
    
        public virtual ObjectResult<Championnats> SP_SelectAllChampionnats(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Championnats>("SP_SelectAllChampionnats", mergeOption);
        }
    
        public virtual ObjectResult<SP_SelectClassement_Result> SP_SelectClassement(Nullable<int> champ_id)
        {
            var champ_idParameter = champ_id.HasValue ?
                new ObjectParameter("champ_id", champ_id) :
                new ObjectParameter("champ_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SelectClassement_Result>("SP_SelectClassement", champ_idParameter);
        }
    
        public virtual ObjectResult<SP_SelectResults_Result> SP_SelectResults(Nullable<int> champ_id, Nullable<int> ssn)
        {
            var champ_idParameter = champ_id.HasValue ?
                new ObjectParameter("champ_id", champ_id) :
                new ObjectParameter("champ_id", typeof(int));
    
            var ssnParameter = ssn.HasValue ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SelectResults_Result>("SP_SelectResults", champ_idParameter, ssnParameter);
        }
    
        public virtual ObjectResult<SP_SelectAllTypeResults_Result> SP_SelectAllTypeResults()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_SelectAllTypeResults_Result>("SP_SelectAllTypeResults");
        }
    }
}
