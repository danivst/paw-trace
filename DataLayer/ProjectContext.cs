using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() { }

        public ProjectContext(DbContextOptions options) : base(options) { }

        public DbSet<FoundAnimal> FoundAnimals { get; set; }
        public DbSet<LostAnimal> LostAnimals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoundAnimal>();
            modelBuilder.Entity<LostAnimal>();
        }
    }
}
