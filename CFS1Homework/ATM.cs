using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            int attempts = 0;

            while (true)
            {
                Console.WriteLine("Enter your account number: ");
                string accountNumber = Console.ReadLine();

                if (accountNumber == "123456")
                {
                    Console.WriteLine("Accecss Granted");

                    int pinAttempts = 0;
                    while (true)
                    {
                        Console.WriteLine("Please enter your PIN to access the Menu Options");
                        string pin = Console.ReadLine();
                        if (pin == "123")
                        {
                            Console.WriteLine("Congrats! You have Access!");
                           int menuChoice = 0;

                           while(menuChoice != 3)
                           {

                                Console.WriteLine("Please choose from the following menu options: ");
                                Console.WriteLine("1) Make a deposit\n2) Make a Withdrawal\n3) Exit\n");
                                menuChoice = int.Parse(Console.ReadLine());
                                int accountBalance = 0;

                                switch (menuChoice)
                                {
                                    case 1:
                                        Console.WriteLine("How much would you like to deposit? ");
                                        int deposit = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"{ deposit:c} has been deposited into account number {accountNumber}");
                                        accountBalance = +deposit;
                                        Console.WriteLine($"Your new account balance is {accountBalance:c}");
                                        break;
                                    case 2:
                                        Console.WriteLine("How much would you like to withdraw> ");
                                        int withdrawal = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"{withdrawal:c} has been withdrawn from your account.");
                                        accountBalance -= withdrawal;
                                        Console.WriteLine($"Your new account balance is {accountBalance:c}");
                                        break;
                                    case 3:
                                        Console.WriteLine("Thank you for your business. Have a wonderful day!");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter a valid option");
                                        break;
                                }
                            }

                           break;
                        }
                        else
                        {
                            Console.WriteLine("incorrect PIN");
                        }
                        pinAttempts++;
                        if (pinAttempts > 2)
                        {
                            Console.WriteLine("Too many failed attempts. Account Locked.");
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
                    Console.WriteLine("Incorrect Account Number");
                }
                attempts++;
                if (attempts > 2)
                {
                    Console.WriteLine("Too many failed attempts. Please try again later.");
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
