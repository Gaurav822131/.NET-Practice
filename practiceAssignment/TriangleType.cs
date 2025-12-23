using System;

namespace practiceAssignment;

public class TriangleType
{
   public static void Triangle()
    {
        System.Console.WriteLine("Enter the first side: ");
        String?input1=Console.ReadLine();
        System.Console.WriteLine("Enter the second side: ");
        String?input2=Console.ReadLine();
        System.Console.WriteLine("Enter the third side: ");
        String?input3=Console.ReadLine();
        if(!int.TryParse(input1,out int side1)||!int.TryParse(input2,out int side2)||!int.TryParse(input3,out int side3))
        {
            System.Console.WriteLine("enter  valid a size!!");
            
    }
    else if ((side1 + side2 < side3) || (side2 + side3 < side1)||(side1+side3==side2))
        {
            System.Console.WriteLine("Not a valid triangle");
        }
        else
        {
            if(side1==side2 && side2 == side3)
            {
                System.Console.WriteLine("Equillateral Triangle");
            }
            else if(side1==side2 || side2 == side3 || side1 == side3)
            {
                System.Console.WriteLine("Isoscles Triangle");
            }
            else
            {
                System.Console.WriteLine("Scalane triangle");
            }
        }
}
}
