using System;

class Logic
{
    public static void Execute()
    {
        // Input
        string?word1 = Console.ReadLine();
        string?word2 = Console.ReadLine();

        string temp = "";

        for (int i = 0; i < word1.Length; i++)
        {
            char ch = char.ToLower(word1[i]);

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                temp += word1[i];
            }
            else
            {
                bool found = false;

                for (int j = 0; j < word2.Length; j++)
                {
                    if (ch == char.ToLower(word2[j]))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    temp += word1[i];
            }
        }

        string result = "";
        for (int i = 0; i < temp.Length; i++)
        {
            if (i == 0 || temp[i] != temp[i - 1])
                result += temp[i];
        }

        // Output
        Console.WriteLine(result);
    }
}
