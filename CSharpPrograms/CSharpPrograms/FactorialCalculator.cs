using System;
public class Factorial
{
    public void FactorialCalci()
    {
        int a = 1;
        Console.WriteLine("Enter the number you want factorial of:");
        int b = int.Parse(Console.ReadLine());
        int i = 1;
        while (i <= b)
        {
            a = a * i;
            i++;
        }
        Console.WriteLine("The factorial of " + b + " is " + a);
    }
}

