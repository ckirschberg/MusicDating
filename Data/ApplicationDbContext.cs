

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicDating.Models.Entities;

namespace MusicDating.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Only needed when inheriting from IdentityDbContext.
            // Call base functionality from the OnModelCreating method in the IdentityDbContext class.
            
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { DateCreated = new System.DateTime(2020, 12, 24), FirstName = "Daniel", LastName = "Something", UserName = "daniel@daniel.dk", Email="daniel@daniel.dk" },
                new ApplicationUser { DateCreated = new System.DateTime(2020, 10, 22), FirstName = "Simone", LastName = "Something else", UserName = "simone@simone.dk", Email="simone@simone.dk"  }
            );


            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Classical" },
                new Genre { GenreId = 2, Name = "Rock" }
            );
            modelBuilder.Entity<Ensemble>().HasData(
                new Ensemble { EnsembleId = 1, Name = "Spice Girls" },
                new Ensemble { EnsembleId = 2, Name = "U2" },
                new Ensemble { EnsembleId = 3, Name = "3 doors down" }
            );

            modelBuilder.Entity<GenreEnsemble>().HasData(
                new GenreEnsemble { EnsembleId = 1, GenreId = 1 },
                new GenreEnsemble { EnsembleId = 1, GenreId = 2 },
                new GenreEnsemble { EnsembleId = 2, GenreId = 1 }
            );


            modelBuilder.Entity<GenreEnsemble>()
                .HasKey(bc => new { bc.GenreId, bc.EnsembleId });  
            modelBuilder.Entity<GenreEnsemble>()
                .HasOne(bc => bc.Ensemble)
                .WithMany(b => b.GenreEnsembles)
                .HasForeignKey(bc => bc.EnsembleId);  
            modelBuilder.Entity<GenreEnsemble>()
                .HasOne(bc => bc.Genre)
                .WithMany(c => c.GenreEnsembles)
                .HasForeignKey(bc => bc.GenreId);
        }

        // This means that EF (Entity Framework) will create a table called Instrument based
        // on our Instrument class.
        public DbSet<Instrument> Instruments { get; set; }

        // This means that EF (Entity Framework) will create a table called Instrument based
        // on our Instrument class.
        public DbSet<MusicDating.Models.Entities.Agent> Agent { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Ensemble> Ensemble { get; set; }
        //public DbSet< MyProperty { get; set; }
    }
}
