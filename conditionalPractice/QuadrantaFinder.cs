using System;

namespace practiceAssignment;

public class QuadrantaFinder
{
    public static void Quad()
    {
        System.Console.WriteLine("Enter the coordinates of X axis: ");
        String?input1=Console.ReadLine();
        System.Console.WriteLine("Enter the coordinates of Y axis: ");
        String?input2=Console.ReadLine();
        if(!int.TryParse(input1,out int X)||!int.TryParse(input2,out int Y))
        {
            System.Console.WriteLine("Invalid input");
        }
        else
        {
            if(X>0 && Y > 0)
            {
                System.Console.WriteLine("Quadrant 1");
            }
            else if(X<0 && Y > 0)
            {
                System.Console.WriteLine("Quadrant 2");
            }
            else if(X<0 && Y < 0)
            {
                System.Console.WriteLine("Quadrant 3");
            }
            else
            {
                System.Console.WriteLine("Quadrant 4");
            }
        }
    }
}
