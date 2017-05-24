using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcMovie.Models
{
    public class MovieDBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MovieDBContext>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Miasta> MIASTA { get; set; }
        public DbSet<Druzyny> DRUZYNY { get; set; }
        public DbSet<Kary> KARY { get; set; }
        public DbSet<Pilkarze> PILKARZE { get; set; }
        public DbSet<Sedziowie> SEDZIOWIE { get; set; }
        public DbSet<Spotkania> SPOTKANIA { get; set; }
        public DbSet<Trenerzy> TRENERZY { get; set; }
        public DbSet<Wynik> WYNIK { get; set; }
  
    }

}