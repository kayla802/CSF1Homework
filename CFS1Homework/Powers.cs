using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            long powerNumber = 1;
            for (int i =0; i < 50; i++)
            {
                Console.WriteLine(powerNumber *= 2);
            }
        }
    }
}
