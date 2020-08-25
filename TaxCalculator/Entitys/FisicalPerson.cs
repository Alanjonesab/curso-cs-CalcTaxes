using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Entitys
{
    class FisicalPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public FisicalPerson()
        {
        }

        public FisicalPerson(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalcTaxes()
        {
            double tax = 0;

            if (AnnualIncome <= 20000)
            {
                tax = AnnualIncome * 0.15;
            }
            else
            {
                if (HealthExpenditures > 0)
                {
                    tax = (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
                }
                else
                {
                    tax = AnnualIncome * 0.25;
                }

            }

            return tax;

        }
    }
}
