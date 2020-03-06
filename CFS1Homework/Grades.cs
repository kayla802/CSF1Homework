using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class Grades
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("How many scores would you like to enter? ");
            int totalNumberOfScores = int.Parse(Console.ReadLine());

            int[] scoresArray = new int[totalNumberOfScores];
            int i = 0;
            int gradeA = 0;
            int gradeB = 0;
            int gradeC = 0;
            int gradeD = 0;
            int gradeF = 0;

            do
            {
                Console.WriteLine("Enter a score:");
                scoresArray[i] = int.Parse(Console.ReadLine());
                

                if (scoresArray[i] >= 90)
                {
                    gradeA++;
                }
                else if (scoresArray[i] >= 80)
                {
                    gradeB++;
                }
                else if (scoresArray[i] >= 70)
                {
                    gradeC++;
                }
                else if (scoresArray[i] >= 60)
                {
                    gradeD++;
                }
                else if (scoresArray[i] >= 0)
                {
                    gradeF++;
                }
                else
                {
                    Console.WriteLine("Not a valid entry, you can no longer enter new scores");
                }

                i++;

            } while (i < totalNumberOfScores);

           
           
             
            
            

            Console.WriteLine("Number of A's: " + gradeA);
            Console.WriteLine("Number of B's: " + gradeB);
            Console.WriteLine("Number of C's: " + gradeC);
            Console.WriteLine("Number of D's: " + gradeD);
            Console.WriteLine("Number of F's: " + gradeF);




        }
    }
}
