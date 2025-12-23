using System;

namespace practiceAssignment;

public class ValidDate
{
    public static void Valid()
    {
        System.Console.WriteLine("Enter the day: ");
        String?input1=Console.ReadLine();
        System.Console.WriteLine("Enter the month: ");
        String?input2=Console.ReadLine();
        System.Console.WriteLine("Enter the year: ");
        String?input3=Console.ReadLine();
        if(!int.TryParse(input1,out int day)&&!int.TryParse(input2,out int month)&&!int.TryParse(input3,out int year))
        {
             System.Console.WriteLine("Invalid data type");
        }
        else
        {
            if (year< 0)
            {
                System.Console.WriteLine("Invalid date");
            }
        }
    }
}
