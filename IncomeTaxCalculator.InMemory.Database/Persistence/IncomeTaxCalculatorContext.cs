using IncomeTaxCalculator.InMemory.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxCalculator.InMemory.Database.Persistence
{
    public class IncomeTaxCalculatorContext : DbContext
    {
        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "IncomeTaxCalculatorDatabase");
        }
        public DbSet<tbl_TaxBracket> TaxBrackets { get; set; }
    }
}
