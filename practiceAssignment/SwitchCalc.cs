using System;

namespace practiceAssignment;

public class SwitchCalc
{
    public static void Calc()
    {
        System.Console.WriteLine("Enter your choice from 1 for add,2 for subtract,3 for product,4 for divide: ");
        String?input=Console.ReadLine();
        int.TryParse(input,out int choice);
        String?inp1=Console.ReadLine();
        String?inp2=Console.ReadLine();
        int.TryParse(inp1,out int num1);
        int.TryParse(inp2,out int num2);
        switch (choice)
        {
            case 1:
            System.Console.WriteLine(num1+num2);
            break;
            case 2:
            System.Console.WriteLine(num1-num2);
            break;
            case 3:
            System.Console.WriteLine(num1*num2);
            break;
            case 4:
            System.Console.WriteLine(num1/num2);
            break;
            default:
            System.Console.WriteLine("Invalid choice");
            break;
            
        }
    }
}
