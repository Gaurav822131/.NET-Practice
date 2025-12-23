using System;
using System.Collections;

namespace practiceAssignment;
// Vowel or Consonant: Use a switch statement to check if a character is a vowel.
public class VowelCheck
{
    public static void Vowel()
    {
        System.Console.WriteLine("Enter the character: ");
        String?input=Console.ReadLine();
        if(!char.TryParse(input,out char character))
        {
            System.Console.WriteLine("!!Not a Valid Character.");
        }
        else
        {
            switch (char.ToLower(character))
            {
                case 'a':
                System.Console.WriteLine("Vowel");
                break;
                case 'e':
                System.Console.WriteLine("Vowel");
                break;
                case 'i':
                System.Console.WriteLine("Vowel");
                break;
                case 'o':
                System.Console.WriteLine("Vowel");
                break;
                case 'u':
                System.Console.WriteLine("Vowel");
                break;
                default:
                System.Console.WriteLine("Consonent");
                break;
            }
        }
    }
}
