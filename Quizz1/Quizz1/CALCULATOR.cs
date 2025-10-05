using System;

public class Calculatorss
{
    public void Calculator()
    {
        int result;
        Console.WriteLine("Enter the number 1st number: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number 2nd number: ");
        int j = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the operation: ");
        char o = char.Parse(Console.ReadLine());
        switch (o)
        {
            case '+':
                result = i + j;
                Console.WriteLine("The result is " + result);
                break;
            case '-':
                result = i - j;
                Console.WriteLine("The result is " + result);
                break;
            case '*':
                result = i * j;
                Console.WriteLine("The result is " + result);
                break;
            case '/':
                result = i / j;
                Console.WriteLine("The result is " + result);
                break;
            default:
                Console.WriteLine("Sorry, This is not an option");
                break;
        }


    }
}

