using IncomeTaxCalculator.InMemory.Database.Entities;
using IncomeTaxCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxCalculator.InMemory.Database.Repository.Interface
{
    public interface IIncomeTaxCalculatorRepository
    {
        Task InitialiseTaxBracketData();
        Task<List<TaxBracket>> AddTaxBrackets(List<TaxBracket> taxBrackets);
        Task<List<TaxBracket>> GetTaxBrackets();

    }
}
