using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the beginning balance: \n");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate: \n");
            double interestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of years: ");
            int years = int.Parse(Console.ReadLine());


            for (int i = 0; i < years; i++)
            {
                balance = (balance+ (balance * interestRate));
            }

            Console.WriteLine($"The amount you will have in {years} years is {balance}");
        }
    }
}
