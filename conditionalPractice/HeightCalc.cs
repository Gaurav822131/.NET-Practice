using System;

namespace practiceAssignment;

public class HeightCalc
{
   public static void  height()
    {
        System.Console.WriteLine("Enter the height: ");
        String? input=Console.ReadLine();
        if(!int.TryParse(input,out int height1))
        {
            System.Console.WriteLine("Invaid height!!");
        }
        else
        {
            if (height1 < 150)
            {
                System.Console.WriteLine("Dwarf");
            }
            else if(height1>150 && height1 < 170)
            {
                System.Console.WriteLine("Average");
            }
            else if(height1>170 && height1 < 190)
            {
                System.Console.WriteLine("Tall");
            }
            else
            {
                System.Console.WriteLine("Abnormal");
            }
        }
    }
}
