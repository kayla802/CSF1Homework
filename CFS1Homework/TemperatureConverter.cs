using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {

            bool repeat = true;
            do
            {
                Console.WriteLine("Temperature Converter");
                Console.WriteLine("Please choose an option:\n1)Celsius to Fahrenheit\n2) Fahrenheit to Celcius\n3) Exit");
                int userChoice = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Please enter the temperature in degrees Celsius: ");
                        double celsiusToFahrenheit = (double.Parse(Console.ReadLine()) * 1.8 + 32);
                        Console.WriteLine("The temperature in Fahrenheit is " + celsiusToFahrenheit + "degrees\n");

                        break;
                    case 2:
                        Console.WriteLine("\nPlease enter the temperature in degrees fahrenheit: ");
                        double fahrenheitToCelsius = (double.Parse(Console.ReadLine()) - 32) / 1.8;
                        Console.WriteLine("The temperature in Celsius is " + fahrenheitToCelsius + "degrees\n");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("\nBye then!!\n");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("\nPlease enter a a valid option");
                        break;
                }
            } while (repeat);


        }
    }
}
