using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Entitys
{
    class LegalPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson()
        {
        }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees)
            : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double CalcTaxes()
        {
            double tax = 0;

            if (NumberOfEmployees <= 10)
            {
                tax = AnnualIncome * 0.16;
            }
            else
            {
                tax = AnnualIncome * 0.14;
            }

            return tax;
        }
    }
}
