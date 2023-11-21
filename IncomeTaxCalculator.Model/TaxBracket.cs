namespace IncomeTaxCalculator.Model
{
    public class TaxBracket
    {
        /// <summary>
        /// The year in which the tax applies to
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// The money count that the tax applies to.
        /// </summary>
        public decimal Money { get; private set; }
        /// <summary>
        /// The tax percentage where 1.0 is 100% tax.
        /// </summary>
        public decimal TaxPercentage { get; private set; }

        public TaxBracket(decimal money, decimal taxPercentage, int year)
        {
            if (money < 0)
                throw new ArgumentOutOfRangeException("Money must be grater than 0");

            if (year <= 0)
                throw new ArgumentOutOfRangeException("Year must be grater than 0");

            if (taxPercentage < 0 || taxPercentage > 1.0m)
                throw new ArgumentOutOfRangeException("Tax Percentage must be between 0.0 and 1.0");
            Money = money;
            TaxPercentage = taxPercentage;
            Year = year;
        }
    }   
}