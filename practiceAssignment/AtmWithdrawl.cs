using System;

namespace practiceAssignment;

public class AtmWithdrawl
{
    public static void Atm()
    {
        System.Console.WriteLine("Card is inserted(yes/no): ");
        String?input=Console.ReadLine();
        if (input == "yes")
        {   
            //int pin=1234;
            System.Console.WriteLine("Enter the Pin:- ");
            String?input1=Console.ReadLine();
            int.TryParse(input1,out int pin);
            if (pin == 1234)
            {
                int balance=5000;
                System.Console.WriteLine("Enter the amount to be withdraw: ");
                String?amount=Console.ReadLine();
                int.TryParse(amount,out int amount1);
                if (amount1 <= balance)
                {
                   System.Console.WriteLine("Withdrawn Successful"); 
                }
                else
                {
                    System.Console.WriteLine("Insufficient balance");
                }   
            }
            else
            {
                System.Console.WriteLine("Invaid Pin");
            }
        }
        else
        {
            System.Console.WriteLine("Card is not Inserted!!");
        }
    }
}
