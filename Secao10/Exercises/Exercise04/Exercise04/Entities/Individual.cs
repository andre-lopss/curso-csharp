namespace Exercise04.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual(string name, double anualIncome, double healthExpenditures) :base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double newTax = 0.0;
            if(AnualIncome < 20000)
            {
                newTax = AnualIncome * 0.15;
            }
            else
            {
                newTax = AnualIncome * 0.25;
            }
            if (HealthExpenditures != 0)
            {
                newTax -= (HealthExpenditures / 2);
            }
            return newTax;
        }
    }
}
