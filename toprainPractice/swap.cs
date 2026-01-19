using System;

public class SwapHelper
{
    public static void SwapUsingRef()
    {
        int a = 10, b = 20;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("Using ref:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }

    public static void SwapUsingOut()
    {
        int x = 30, y = 40;
        int p, q;

        p = x + y;
        q = p - y;
        p = p - q;

        Console.WriteLine("\nUsing out:");
        Console.WriteLine("p = " + p);
        Console.WriteLine("q = " + q);
    }
}
