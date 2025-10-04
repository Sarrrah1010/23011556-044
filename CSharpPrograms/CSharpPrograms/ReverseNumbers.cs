using System;
public class Reverse
{
    public void ReverseNumbers()
    {
        Console.WriteLine("ENTER THE NUMBER (More than one digit) : ");
        int a = int.Parse(Console.ReadLine());
        int r = 0;
        while (a != 0)
        {
            int digit = a % 10;
            r = r * 10 + digit;
            a = a / 10;
        }
        Console.WriteLine("The result is : " + r);
    }
}
