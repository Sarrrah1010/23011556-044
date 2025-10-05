using System;
public class EVENorODD
{
    public void EvenOrOdd()
    {
        Console.WriteLine(" Enter the number : ");
        int num=int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("The " + num + " is even ");
        }
        else
        {
            Console.WriteLine("The " + num + " is odd ");
        }
        Console.ReadLine();
    }
}