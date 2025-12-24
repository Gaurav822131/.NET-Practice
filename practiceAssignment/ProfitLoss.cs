using System;
using System.Collections.Concurrent;

namespace practiceAssignment;

public class ProfitLoss
{
    public static void Pl()
    {
        System.Console.WriteLine("Enter the CP of the product: -");
        String?input1=Console.ReadLine();
        int.TryParse(input1,out int cp);
        System.Console.WriteLine("Enter the SP of Product: ");
        String?input2=Console.ReadLine();
        int.TryParse(input2,out int sp);
        if (cp > sp)
        {
            int loss=cp-sp;
            System.Console.WriteLine("Loss% is "+(loss*100)/cp);
        }
        else
        {
            int profit=sp-cp;
            System.Console.WriteLine("Profit% is: "+(profit*100)/cp);
        }
    }
}
