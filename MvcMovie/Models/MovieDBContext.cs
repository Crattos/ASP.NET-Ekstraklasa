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
        public DbSet<Miasto> MIASTA { get; set; }
        public DbSet<Druzyna> DRUZYNY { get; set; }
        public DbSet<Kara> KARY { get; set; }
        public DbSet<Pilkarz> PILKARZE { get; set; }
        public DbSet<Sedzia> SEDZIOWIE { get; set; }
        public DbSet<Spotkanie> SPOTKANIA { get; set; }
        public DbSet<Trener> TRENERZY { get; set; }
        public DbSet<Wynik> WYNIK { get; set; }
  
    }

}