using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class Login
    {
        static void Main(string[] args)
        {

            int attempts = 0;


            while (true)
            {
                Console.WriteLine("Enter your username");
                string userNameInput = Console.ReadLine();

                if (userNameInput == "Kayla")
                {
                    Console.WriteLine("Congrats! you have access!");
                   
                    int passwordAttempts = 0;
                    while (true)
                    {
                        Console.WriteLine("Please enter your password:");
                        string password = Console.ReadLine();
                        if (password == "Lionel")
                        {
                            Console.WriteLine("Account access granted.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Password Incorrect, please try again.");
                        }
                        passwordAttempts++;
                        if (passwordAttempts > 2)
                        {
                            Console.WriteLine("Too many failed attempts. Account locked");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Username does not exist, please try again.");
                }
                attempts++;
                if (attempts > 2)
                {
                    Console.WriteLine("Too many failed attempts.");
                    break;
                }
                else
                {
                    continue;
                }

            }

        }
    }
}
