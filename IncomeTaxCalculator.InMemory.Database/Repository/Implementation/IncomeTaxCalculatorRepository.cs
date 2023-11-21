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
        private readonly ILogger<IncomeTaxCalculatorRepository> _logger;

        public IncomeTaxCalculatorRepository(ILogger<IncomeTaxCalculatorRepository> logger) 
        {
            _logger = logger;
        }
        public async Task<List<TaxBracket>> AddTaxBrackets(List<TaxBracket> taxBrackets)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaxBracket>> GetTaxBrackets()
        {
            throw new NotImplementedException();
        }

        public async Task InitialiseTaxBracketData()
        {
            throw new NotImplementedException();
        }
    }
}
