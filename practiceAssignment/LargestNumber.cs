using System;

namespace practiceAssignment;

public class LargestNumber
{
   public static void Largest()
    {
        System.Console.WriteLine("Enter the first number:- ");
        String?num1=Console.ReadLine();
        System.Console.WriteLine("Enter the second number:- ");
        String?num2=Console.ReadLine();
        System.Console.WriteLine("Enter the third number:- ");
        String?num3=Console.ReadLine();

        if((!int.TryParse(num1,out int a))||(!int.TryParse(num2,out int b))||(!int.TryParse(num3,out int c)))
        {
            System.Console.WriteLine("Invalid Input");
        }
        else
        {
            if (a > b && a > c)
            {
                System.Console.WriteLine(a+" is largest");
            }
            else if(b>a && b > c)
            {
                System.Console.WriteLine(b+" is largest");
            }
            else
            {
                System.Console.WriteLine(c+" is largest");
            }
        }
    }
}
