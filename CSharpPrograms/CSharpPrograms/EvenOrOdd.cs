using System;

public class EvenOrOdd
{
    public void CheckEvenOdd()
    {
        int x;
        Console.WriteLine("Enter the number you want to check: ");
        x = int.Parse(Console.ReadLine());

        if (x % 2 == 0)
            Console.WriteLine("Your entered " + x + " and it is EVEN");
        else
            Console.WriteLine("Your entered " + x + " and it is ODD");

        Console.ReadLine();
    }
}
