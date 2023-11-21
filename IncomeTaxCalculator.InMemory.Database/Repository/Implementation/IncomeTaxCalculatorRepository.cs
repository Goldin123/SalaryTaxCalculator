// Ignore Spelling: Initialise

using IncomeTaxCalculator.InMemory.Database.Entities;
using IncomeTaxCalculator.InMemory.Database.Persistence;
using IncomeTaxCalculator.InMemory.Database.Repository.Interface;
using IncomeTaxCalculator.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxCalculator.InMemory.Database.Repository.Implementation
{
    public class IncomeTaxCalculatorRepository : IIncomeTaxCalculatorRepository
    {
        //CEHCK AUTO MAPPER
        private readonly ILogger<IncomeTaxCalculatorRepository> _logger;

        public IncomeTaxCalculatorRepository(ILogger<IncomeTaxCalculatorRepository> logger)
        {
            _logger = logger;
        }
        public async Task<List<TaxBracket>> AddTaxBrackets(List<TaxBracket> taxBrackets)
        {
            try
            {
                var taxBracketDBValues = SetTableTaxBracket(taxBrackets);

                if (taxBracketDBValues.Count > 0)
                {
                    using (var db = new IncomeTaxCalculatorContext())
                    {
                        db.TaxBrackets.AddRange(taxBracketDBValues);
                        db.SaveChanges();
                    }
                }
                return taxBrackets; //CHECK THIS OUT
            }
            catch (Exception ex)
            {
                _logger.LogCritical(string.Format("{0} - {1}", DateTime.Now, ex.Message));
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TaxBracket>> GetTaxBrackets()
        {
            try
            {
                using (var db = new IncomeTaxCalculatorContext())
                {
                    return db.TaxBrackets.Select(a => new TaxBracket(a.Money, a.TaxPercentage, a.Year)).ToList();
                }

            }
            catch (Exception ex)
            {
                _logger.LogCritical(string.Format("{0} - {1}", DateTime.Now, ex.Message));
                throw new Exception(ex.Message);
            }
        }

        public async Task InitialiseTaxBracketData()
        {
            try
            {
                var _taxLevels = new List<TaxBracket>() {
                               new TaxBracket (4770m, 0.10m,2023 ),
                               new TaxBracket (3700m, 0.14m,2023 ),
                               new TaxBracket (4249m, 0.20m,2023 ),
                               new TaxBracket (5529m, 0.28m,2023 ),
                               new TaxBracket (21089m, 0.31m,2023 ),
                               new TaxBracket (decimal.MaxValue, 0.42m ,2023),
                            };
                await AddTaxBrackets(_taxLevels);

            }
            catch (Exception ex)
            {
                _logger.LogCritical(string.Format("{0} - {1}", DateTime.Now, ex.Message));
                throw new Exception(ex.Message);
            }
        }

        List<tbl_TaxBracket> SetTableTaxBracket(List<TaxBracket> taxBrackets)
        {
            try
            {
                if (taxBrackets.Count > 0)
                {
                    var taxBkts = new List<tbl_TaxBracket>();
                    taxBkts = taxBrackets.Select(taxBracket => new tbl_TaxBracket()
                    {
                        DateAdded = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        Money = taxBracket.Money,
                        Year = taxBracket.Year,
                        TaxPercentage = taxBracket.TaxPercentage,

                    }).ToList();
                    return taxBkts;
                }

                return new List<tbl_TaxBracket>();
            }
            catch { return new List<tbl_TaxBracket>(); }
        }
    }
}
