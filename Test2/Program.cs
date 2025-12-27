using System;

namespace MediSureClinic
{
    class Program
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1.Create  2.View  3.Clear  4.Exit");
                Console.Write("Choice: ");
                string?ch = Console.ReadLine();

                switch (ch)
                {
                    case "1": BillService.CreateNewBill(); break;
                    case "2": BillService.ViewLastBill(); break;
                    case "3": BillService.ClearLastBill(); break;
                    case "4": exit = true; break;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }
    }
}




