namespace Exercise04.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees): base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double newTax = 0.0;
            if(NumberOfEmployees > 10)
            {
                newTax = AnualIncome * 0.14;
            }
            else
            {
                newTax = AnualIncome * 0.16;
            }
            return newTax;
        }
    }
}
