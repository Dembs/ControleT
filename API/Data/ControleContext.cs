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

 
        public DbSet<Record> Records {get; set;}



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Record>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
