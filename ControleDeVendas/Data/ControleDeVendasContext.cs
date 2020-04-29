using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ControleDeVendas.Models
{
    public class ControleDeVendasContext : DbContext
    {
        public ControleDeVendasContext (DbContextOptions<ControleDeVendasContext> options)
            : base(options)
        {
        }

        public DbSet<ControleDeVendas.Models.Department> Department { get; set; }
    }
}
