// Ignore Spelling: UIF

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxCalculator.Model
{
    public class TaxSalaryResponse
    {
        public decimal? GrossAmount { get; set; }
        public decimal? NettAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? UIF { get; set; }
        public decimal? TaxPercentage { get; set; }

        public TaxSalaryResponse(decimal? grossAmount, decimal? nettAmount, decimal? taxAmount, decimal? uif, decimal? taxPercentage)
        {
            GrossAmount = grossAmount;
            NettAmount = nettAmount;
            TaxAmount = taxAmount;
            UIF = uif;
            TaxPercentage = taxPercentage;
        }
    }
}
