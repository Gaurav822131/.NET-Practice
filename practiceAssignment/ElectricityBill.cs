using System;

namespace practiceAssignment;
// Calculate bill: First 199 units @ 1.20; 200-400 @ 1.50; 400-600 @ 1.80; above 600 @ 2.00. Add 15% surcharge if bill > 400.
public class ElectricityBill
{
    public static void Electricity()
    {
        System.Console.WriteLine("Enter the number of uit consumptions:- ");
        String? input = Console.ReadLine();
        if(!double.TryParse(input,out double Unit))
        {
            System.Console.WriteLine("Enter a valid unit.!!");
        }
        else
        {
            if (Unit < 199)
            {
                System.Console.WriteLine("Your total bill is: "+Unit*1.20);
            }
            else if(Unit>199 && Unit < 400)
            {
                System.Console.WriteLine("Your Tota Bill is: "+(Unit*1.50));
            }
            else if (Unit >= 400 && Unit <= 600)
            {
                System.Console.WriteLine("Your Total Bill is: "+(Unit*1.80+(Unit*15/100)));
            }
            else
            {
                System.Console.WriteLine("Your Total Bill is: "+(Unit*2+(Unit*15/100)));
            }
        }
    }

}
