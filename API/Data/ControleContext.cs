using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ControleContext : DbContext 
    {
        public ControleContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Garage> Garages {get; set;}
        
    }
}