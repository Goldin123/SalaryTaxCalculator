namespace IncomeTaxCalculator.Model
{
    public class TaxSalaryRequest
    {
        public decimal GrossAmount { get; set; }      
        public int TaxYear { get; set; }      
        public DateTime DateOfBirth { get; set; }
        public PayFrequency IncomeFrequency { get; set; }
        public decimal? AnnualBonus { get; set; }
        public Allowance? Allowance { get; set; }
        public PayContribution? ProvidentFund { get; set; }
        public PayContribution? PensionFund { get; set; }
        public PayContribution? RetirementAnnuity { get; set; }
        public MedicalAid? MedicalAidPay { get; set; }
        public TaxSalaryRequest(decimal grossAmount, int taxYear, DateTime dateOfBirth, PayFrequency incomeFrequency, decimal? annualBonus, Allowance? allowance, PayContribution? providentFund, PayContribution? pensionFund, PayContribution? retirementAnnuity, MedicalAid? medicalAidPay)
        {
            GrossAmount = grossAmount;
            TaxYear = taxYear;
            DateOfBirth = dateOfBirth;
            IncomeFrequency = incomeFrequency;
            AnnualBonus = annualBonus;
            Allowance = allowance;
            ProvidentFund = providentFund;
            PensionFund = pensionFund;
            RetirementAnnuity = retirementAnnuity;
            MedicalAidPay = medicalAidPay;
        }
    }

    public enum PayFrequency 
    {
        Weekly = 1,
        BiWeekly = 2,
        Monthly = 3,
        Annually = 4
    }

    public class PayContribution 
    {
        public decimal? OwnAmount { get; set; }
        public decimal? CompanyAmount { get; set; }

        public PayContribution(decimal? ownAmount, decimal? companyAmount)
        {
            if (ownAmount < 0)
                throw new ArgumentOutOfRangeException("Own amount must be grater than 0");

            if (companyAmount < 0)
                throw new ArgumentOutOfRangeException("Company amount must be grater than 0");

            OwnAmount = ownAmount;
            CompanyAmount = companyAmount;
        }
    }

    public class Allowance 
    {
        public decimal? Travel { get; set; }
        public decimal? Home { get; set; }
        public decimal? Phone { get; set; }
        public decimal? Food { get; set; }

        public Allowance(decimal? travel, decimal? home, decimal? phone, decimal? food)
        {
            if(travel < 0)
                throw new ArgumentOutOfRangeException("travel amount must be grater than 0");
            if(home < 0)
                throw new ArgumentOutOfRangeException("home amount must be grater than 0");

            if(food < 0)
                throw new ArgumentOutOfRangeException("food amount must be grater than 0");

            if(phone < 0)
                throw new ArgumentOutOfRangeException("phone amount must be grater than 0");

            Travel = travel;
            Home = home;
            Phone = phone;
            Food = food;
        }
    }

    public class MedicalAid : PayContribution
    {
        public int Dependency { get; set; }
        public MedicalAid(decimal? ownAmount, decimal? companyAmount, int dependency) : base(ownAmount, companyAmount)
        {
            Dependency = dependency;
        }
    }
}