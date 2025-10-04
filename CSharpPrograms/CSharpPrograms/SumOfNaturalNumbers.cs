

using System;

public class Sum
{
    public void SumNumbers()
    {
        int a;
        int x = 0;
        Console.WriteLine("Enter the number : ");
        a = int.Parse(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {

            x = x + i;
        }
        Console.WriteLine("the sum is " + x);
    }
}

