using System;
public class Program4
{
    public static void Main()
    {
        Console.WriteLine("Odd numbers from 1 to 10.");
        for (int n = 1; n < (10 + 1); n++)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine(n.ToString());
            }
        }

    }
}
