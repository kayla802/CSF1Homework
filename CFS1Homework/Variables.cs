using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class Variables
    {
        static void Main(string[] args)
        {
            char initial = 'K';
            Console.WriteLine(initial);

            string name = "Kayla";
            Console.WriteLine(name);

            double age = 30.9;
            Console.WriteLine(age);

            float hoursPlayingBOTW = 352.2F;
            Console.WriteLine(hoursPlayingBOTW);

            byte numberByte = 250;
            Console.WriteLine(numberByte);

            int[] numbers = { 12, 23, 56, 2, 89 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            char[] letters = { 'k', 'a', 'y', 'l', 'a' };
            foreach (char letter in letters)
            {
                Console.WriteLine(letter);
            }

            string[] words = { "Kayla", "Emmett", "Noa", "Lionel", "Tallulah" };
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            double[] dblArray = { 1.25, 2.25, 6.35, 5, 7.77 };
            foreach (double number in dblArray)
            {
                Console.WriteLine(number);
            }

            float[] fltArray = { 1.25F, 2.36F, 8.52F, 7.54F, 8F };
            foreach (float num in fltArray)
            {
                Console.WriteLine(num);
            }

            byte[] byteNbr = { 1, 2, 3, 4, 5 };
            foreach (byte nbr in byteNbr)
            {
                Console.WriteLine(nbr);
            }

            int countByTwo = 0;

            while (countByTwo <= 100)
            {
                Console.WriteLine(countByTwo);
                countByTwo += 2;
            }
            Console.WriteLine();
            int countByTwoDoWhile = 0;
            do
            {
                Console.WriteLine(countByTwoDoWhile);
                countByTwoDoWhile += 2;
            } while (countByTwoDoWhile <= 100);

            int countByTwoFor = 100;
            for (int i = 0; i <= countByTwoFor; i+=2)
            {
                Console.WriteLine(i); 
            }
        }
    }
}
