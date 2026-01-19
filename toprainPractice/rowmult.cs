using System;

public class SolutionDefault
{
    public static int[] GetMultiplicationRow(int n, int upto)
    {
        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }

    public static void Main()
    {
        int n = 3;
        int upto = 5;

        int[] result = GetMultiplicationRow(n, upto);

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}
