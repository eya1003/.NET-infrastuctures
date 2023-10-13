using Microsoft.EntityFrameworkCore;
using SW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SW.DataAcessLayer
{
    public class StarWarsDBContext : DbContext
    {
        public DbSet<Citoyen> Citoyens { get; set; }
        public StarWarsDBContext( DbContextOptions<StarWarsDBContext> options) : base(options)
        {

            
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
            modelBuilder.Entity<Citoyen>().HasOne<Citoyen>(c => c.PereBiologique);
            modelBuilder.Entity<Citoyen>().HasOne<Citoyen>(c => c.MereBiologique);

        }
    }
}
