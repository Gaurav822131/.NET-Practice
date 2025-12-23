using System;

namespace practiceAssignment;

public class GradeDiscriptor
{
    public static void Grade()
    {
        System.Console.WriteLine("Enter the grade:- ");
        String? input = Console.ReadLine();
        if(!char.TryParse(input,out char grade))
        {
            System.Console.WriteLine("Invalid input type");
        }
        else
        {
            switch (char.ToUpper(grade))
            {
                case 'E':
                System.Console.WriteLine("Excellent");
                break;
                case 'V':
                System.Console.WriteLine("Very Good");
                break;
                case 'G':
                System.Console.WriteLine("Good");
                break;
                case 'A':
                System.Console.WriteLine("Average");
                break;
                case 'F':
                System.Console.WriteLine("Fail");
                break;
                default:
                System.Console.WriteLine("Inavlid grade");
                break;
            }
        }
    }
}
