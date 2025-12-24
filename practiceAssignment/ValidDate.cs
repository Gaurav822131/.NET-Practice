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
        int flag=1;
        if(!int.TryParse(input1,out int day))
        {
             System.Console.WriteLine("Invalid data type");
        }
        if(!int.TryParse(input1,out int month))
        {
             System.Console.WriteLine("Invalid data type");
        }
        if(!int.TryParse(input1,out int year))
        {
             System.Console.WriteLine("Invalid data type");
        }

        else
        {
            if (year< 0)
            {
               flag=0; 
            }
            else if(day<0 || month > 12)
            {
                flag=0;
            }
            else
            {
                int [] days={31,28,31,30,31,30,31,31,30,31,30,31};
                if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    
                    days[1]=29;
                }
                if (day < 1 || day > days[month - 1])
                {
                    flag=0;
                }
            }
        }
        if (flag == 0)
        {
            System.Console.WriteLine("Invalid date");
        }
        else
        {
            System.Console.WriteLine("Valid Date");
        }
    }
}
