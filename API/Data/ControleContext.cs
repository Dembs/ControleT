using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ControleContext : DbContext 
    {
        public ControleContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Fields> Field {get; set;}
        public DbSet<Record> Records {get; set;}
        public DbSet<Root> Roots {get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fields>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Record>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Root>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
