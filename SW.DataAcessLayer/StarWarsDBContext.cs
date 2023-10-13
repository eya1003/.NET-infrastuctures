using Microsoft.EntityFrameworkCore;
using SW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
