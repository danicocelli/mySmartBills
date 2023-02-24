using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.GestorFinanceiro.App.Models;

namespace Web.GestorFinanceiro.App.Data
{
    public class WebGestorFinanceiroAppContext : DbContext
    {
        public WebGestorFinanceiroAppContext (DbContextOptions<WebGestorFinanceiroAppContext> options)
            : base(options)
        {
        }

        public DbSet<Despesa> Despesa { get; set; } = default!;

        public DbSet<Usuario> Usuario { get; set; }
    }
}
