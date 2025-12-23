using System;

namespace practiceAssignment;
//Math ≥ 65, Phys ≥ 55, Chem ≥ 50 AND (Total ≥ 180 OR Math+Phys ≥ 140).
public class AdmissionEligibilty
{
    public static void Adm()
    {
        System.Console.WriteLine("Enter the marks in Math:- ");
        String?marks1=Console.ReadLine();
        System.Console.WriteLine("Enter the marks in Phy:- ");
        String?marks2=Console.ReadLine();
        System.Console.WriteLine("Enter the marks in Chem:- ");
        String?marks3=Console.ReadLine();
        if((!int.TryParse(marks1,out int math))||(!int.TryParse(marks2,out int Phy))||(!int.TryParse(marks1,out int chem)))
        {
            System.Console.WriteLine("Invalid input");
        }
        else
        {
            if(((math>=65)&&(Phy>=55)&&(chem>=50)&&(math+Phy+chem>=180 || (math + Phy) > 140))){
                System.Console.WriteLine("Eligible for admission");
            }
            else
            {
                System.Console.WriteLine("Not eligile for admission");
            }
        }

    }
}
