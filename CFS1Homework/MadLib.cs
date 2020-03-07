using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************Mad Lib*********************************************");

            Console.WriteLine("Please enter the following information below to complete this Mad Lib. Unless otherwise specified" +
                "all verbs should be in present tense.");


            Console.Write("Noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Adjective ending in -ful: ");
            string fulAdjective1 = Console.ReadLine();

            Console.Write("Adjective: ");
            string adjective1 = Console.ReadLine();

            Console.Write("Noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Verb ending in -ing: " );
            string ingVerb1 = Console.ReadLine();

            Console.Write("Adjective to describe a person: ");
            string personAdjective1 = Console.ReadLine();

            Console.Write("Adjective to describe a person: ");
            string personAdjective2 = Console.ReadLine();

            Console.Write("Adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Past Tense Verb: ");
            string pastTenseVerb = Console.ReadLine();

            Console.Write("Adjective: ");
            string adjective3 = Console.ReadLine();

            Console.Write("Adjective: ");
            string adjective4 = Console.ReadLine();

            Console.Write("Noun: ");
            string noun3 = Console.ReadLine();

            Console.Write("Noun: ");
            string noun4 = Console.ReadLine();

            Console.WriteLine("Press enter to see your story!");
            Console.ReadLine();

            Console.WriteLine($"Just sit right back and you'll hear a tale, a tale of a {fulAdjective1} {noun1}, that started at this" +
                $" {adjective1} port aboard this tiny {noun2}. The mate was a mighty {ingVerb1} man,  the skipper {personAdjective1} and " +
                $"{personAdjective2}. Five passengers set sail that day on a three hour tour, a three hour tour. The weather started getting " +
                $"{adjective2}, The tiny {noun2} was {pastTenseVerb}. If not for the courage of the {adjective3} crew the Minnow would be " +
                $"Lost. The minnow would be lost. The {noun2} set ground on the shore of this {adjective4} desert isle. With Gilligan, the Skipper " +
                $"too, a millionaire and his {noun3}, a {noun4} star, The Professor, and Mary Ann, Here on Gilligan's Isle.");


        }
    }
}
