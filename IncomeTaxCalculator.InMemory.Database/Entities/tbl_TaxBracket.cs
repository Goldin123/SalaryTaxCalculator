using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxCalculator.InMemory.Database.Entities
{
    public class tbl_TaxBracket
    {
        [Key]
        public int ID { get; set; }
        public int Year { get; set; }
        public decimal Money { get; set; }
        public decimal TaxPercentage { get; set; } 
        public DateTime? DateAdded { get; set; } 
        public DateTime? DateUpdated { get; set; } 
    }
}
