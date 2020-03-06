using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class Counting
    {
        static void Main(string[] args)
        {

            //1.Display numbers 1 to 25 on the screen with a loop
            int number = 25;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

            //2. Display numbers 25 to 1 on the screen with a loop
            int nbr = 0;
            for (int i = 25; i > nbr; i--)
            {
                Console.WriteLine(i);
            }
            //3 Display number from 0 to 50 by 2s with a loop.
            int num = 50;
            for (int i = 0; i <= num; i+=2)
            {
                Console.WriteLine(i);
            }

            double numDouble = 10;
            for (double i = 0; i <= numDouble; i += 0.5)
            {
                Console.WriteLine(i);
            }

        }
    }
}
