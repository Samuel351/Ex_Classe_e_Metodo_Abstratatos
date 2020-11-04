using Exercícios_Abstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercícios_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company(i/c)? ");
                char r = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(r == 'i')
                {
                    Console.Write("Expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, expenditures));
                }
                else
                {
                    Console.Write("Employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employee));
                }       
            }
            double sum = 0.0;
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer taxpayer in list)
            {
                double tax = taxpayer.Tax();
                Console.WriteLine($"{taxpayer.Name} :  ${taxpayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("TOTAL: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
