using AfpaTinderCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AfpaTinderCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        #region DbSet
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Loisir> Loisirs { get; set; }
        public DbSet<PersonneLoisir> PersonneLoisirs { get; set; }
        public DbSet<SituationFamiliale> SituationFamiliales { get; set; }
        public DbSet<OrientationSexuelle> OrientationSexuelles { get; set; }
        public DbSet<TypeRelation> TypeRelations { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PersonneLoisir>()
                .HasKey(pl => new { pl.PersonneId, pl.LoisirId });

        }
    }
}
