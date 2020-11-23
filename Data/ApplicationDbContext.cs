

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
                new ApplicationUser { Id="1", DateCreated = new System.DateTime(2020, 12, 24), FirstName = "Daniel", LastName = "Something", UserName = "daniel@daniel.dk", Email="daniel@daniel.dk" },
                new ApplicationUser { Id="2", DateCreated = new System.DateTime(2020, 10, 22), FirstName = "Simone", LastName = "Something else", UserName = "simone@simone.dk", Email="simone@simone.dk"  }
            );

            // Add data - instruments
            modelBuilder.Entity<Instrument>().HasData(
                new Instrument { InstrumentId = 7, Name = "Violin" },
                new Instrument { InstrumentId = 8, Name = "Guitar" },
                new Instrument { InstrumentId = 9, Name = "Piano" }
            );

            // Add data - userinstruments
            modelBuilder.Entity<UserInstrument>().HasData(
                new UserInstrument {Id = "1", InstrumentId = 7, Level = 3 },
                new UserInstrument {Id = "1", InstrumentId = 8, Level = 5 },
                new UserInstrument {Id = "1", InstrumentId = 9, Level = 2 }
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


            modelBuilder.Entity<UserInstrumentGenre>().HasData(
                new UserInstrumentGenre { UserInstrumentGenreId = 1, Id="1", InstrumentId=7, GenreId=1},
                new UserInstrumentGenre { UserInstrumentGenreId = 2, Id="1", InstrumentId=7, GenreId=2},
                new UserInstrumentGenre { UserInstrumentGenreId = 3, Id="1", InstrumentId=8, GenreId=2}
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


            modelBuilder.Entity<UserInstrument>()
                .HasKey(bc => new { bc.Id, bc.InstrumentId });  
            modelBuilder.Entity<UserInstrument>()
                .HasOne(bc => bc.ApplicationUser)
                .WithMany(b => b.UserInstruments)
                .HasForeignKey(bc => bc.Id);  
            modelBuilder.Entity<UserInstrument>()
                .HasOne(bc => bc.Instrument)
                .WithMany(c => c.UserInstruments)
                .HasForeignKey(bc => bc.InstrumentId);
            

            modelBuilder.Entity<UserInstrumentGenre>()
                .HasKey(bc => bc.UserInstrumentGenreId);  
            modelBuilder.Entity<UserInstrumentGenre>()
                .HasOne(bc => bc.Genre)
                .WithMany(b => b.UserInstrumentsGenres)
                .HasForeignKey(bc => bc.GenreId);  
            modelBuilder.Entity<UserInstrumentGenre>()
                .HasOne(bc => bc.UserInstrument)
                .WithMany(c => c.UserInstrumentsGenres)
                .HasForeignKey(bc => new {bc.Id, bc.InstrumentId});
        }

        // This means that EF (Entity Framework) will create a table called Instrument based
        // on our Instrument class.
        public DbSet<Instrument> Instruments { get; set; }

        // This means that EF (Entity Framework) will create a table called Instrument based
        // on our Instrument class.
        public DbSet<MusicDating.Models.Entities.Agent> Agent { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Ensemble> Ensemble { get; set; }
        public DbSet<UserInstrument> UserInstruments { get; set; }

         public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        
        public DbSet<UserInstrumentGenre> UserInstrumentGenres { get; set; }
    }
}
