using Modele.Entities;
using System.Data.Entity;

namespace Modele
{
    public class MappingMetierBase : DbContext
    {
        public MappingMetierBase() : base("Database")
        {

        }

        public DbSet<Employe> Employes { get; set; }

        public DbSet<Formation> Formations { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Postulation> Postulations { get; set; }

        public DbSet<Offre> Offres { get; set; }
    }
}
