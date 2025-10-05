using System;

public class EvenOdd
{
    public void EvenOrOddArray()
    {
        int[] numbers = new int[10];
        int evenCount = 0, oddCount = 0;

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Number i + 1: ");
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i]%2 == 0){
                evenCount++;
            }
            else
                oddCount++;


            Console.WriteLine("\nEven numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
        }
    }
}
