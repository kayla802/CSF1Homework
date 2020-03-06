using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class MinMaxAvg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 5 different numbers and press enter after each number");
            int userNumber1 = int.Parse(Console.ReadLine());
            int userNumber2 = int.Parse(Console.ReadLine());
            int userNumber3 = int.Parse(Console.ReadLine());
            int userNumber4 = int.Parse(Console.ReadLine());
            int userNumber5 = int.Parse(Console.ReadLine());

            int[] userNumberArray = { userNumber1, userNumber2, userNumber3, userNumber4, userNumber5 };
            Array.Sort(userNumberArray);
            int minNbr = userNumberArray[0];
            int maxNbr = userNumberArray[4];
            int sumOfNumbers = userNumberArray.Sum();
            int average = sumOfNumbers / userNumberArray.Length;

            Console.WriteLine(minNbr);
            Console.WriteLine(maxNbr);
            Console.WriteLine(average);

        }
       
    }
}
