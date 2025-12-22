using System;

namespace practiceAssignment;

public class LeapCheck
{
   public static void Leap()
    {
        System.Console.WriteLine("Enter the year:- ");
        String?input=Console.ReadLine();
        if(!int.TryParse(input,out int year1))
        {
            System.Console.WriteLine("Invalid Year");
        }
        else
        {
            if((year1%400==0)||(year1%4==0 && year1 % 100 != 0))
            {
                System.Console.WriteLine("Leap Year");
            }
            else
            {
                System.Console.WriteLine("Not a leap Year");
            }
        }
    }
}
