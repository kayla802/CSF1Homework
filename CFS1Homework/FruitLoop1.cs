using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            string[] fruitNames = { "apple", "banana", "orange", "grape", "pear" };
            int count = 0;

            while  (count <= fruitNames.Length-1)
            {
                Console.WriteLine(fruitNames[count]);
                count++;
            }
        }
    }
}
