using System;

namespace QuickMart;
    class Program
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n QuickMart Traders ");
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                string?choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TransactionService.CreateNewTransaction();
                        break;
                    case "2":
                        TransactionService.ViewLastTransaction();
                        break;
                    case "3":
                        TransactionService.RecalculateProfitLoss();
                        break;
                    case "4":
                        Console.WriteLine("\nThank you. Application closed normally.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

