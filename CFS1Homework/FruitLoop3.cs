using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class FruitLoop3
    {
        static void Main(string[] args)
        {
            string[] fruitNames = { "apple", "banana", "orange", "grape", "pear" };
            string[] dots = { ".", "..", "...", "....", "....." };
            for (int i = 0; i < fruitNames.Length; i++)
            {
                Console.WriteLine(fruitNames[i]);
                Console.WriteLine(dots[i]);

            }
            
        }
    }
}
