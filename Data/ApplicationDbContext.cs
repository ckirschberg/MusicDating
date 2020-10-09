

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
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = 1,
                    Name = "Classical"
                },
                new Genre
                {
                    GenreId = 2,
                    Name = "Rock"
                }
            );
            modelBuilder.Entity<Ensemble>().HasData(
                new Ensemble { EnsembleId = 1, Name = "Ensemble 1" },
                new Ensemble { EnsembleId = 2, Name = "Ensemble 2" },
                new Ensemble { EnsembleId = 3, Name = "Ensemble 3" }
            );


            modelBuilder.Entity<GenreEnsemble>().HasData(
                new GenreEnsemble { EnsembleId = 1, GenreId = 1 },
                new GenreEnsemble { EnsembleId = 2, GenreId = 1 },
                new GenreEnsemble { EnsembleId = 1, GenreId = 2 }
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
    }
}
