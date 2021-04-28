using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortfolioDiseño.Models;

namespace PortfolioDiseño.Data
{
    public class PortfolioDiseñoContext : DbContext
    {
        public PortfolioDiseñoContext (DbContextOptions<PortfolioDiseñoContext> options)
            : base(options)
        {
        }

        public DbSet<PortfolioDiseño.Models.Work> Works { get; set; }
    }
}
