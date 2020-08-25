using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Schema;
using TaxCalculator.Entitys;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            
            Console.Write("Enter the number of payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax payer #{0} data: ", i);
                Console.Write("Fisical or Legal (l/f): ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'l')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: R$ ");
                    double income = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees:  ");
                    int number = int.Parse(Console.ReadLine());

                    persons.Add(new LegalPerson(name, income, number));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: R$ ");
                    double income = double.Parse(Console.ReadLine());
                    Console.Write("Health Expenditures:  ");
                    double exp = double.Parse(Console.ReadLine());

                    persons.Add(new FisicalPerson(name, income, exp));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double total = 0;

            foreach (Person person in persons)
            {
                
                Console.WriteLine(person.Name + ": $" + person.CalcTaxes().ToString("F2", CultureInfo.InvariantCulture));
                total += person.CalcTaxes();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
