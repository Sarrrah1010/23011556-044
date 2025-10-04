using System;

public class MinMax
{
    public void FindMinMax()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];

            if (numbers[i] < min)
                min = numbers[i];
        }

        Console.WriteLine("\nMaximum number: " + max);
        Console.WriteLine("Minimum number: " + min);
    }
}
