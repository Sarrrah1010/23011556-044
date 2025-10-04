using System;

public class Table
{
    public void TableOfN()
    {
        int x;
        Console.WriteLine("Write the number : ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine("Following is the table \n");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(x + "*" + i + "=" + x * i);
        }

    }
}

