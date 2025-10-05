using System;
public class cube
{
    public void CUBEOFNO()
    {

        Console.WriteLine("Enter the number");
        int n = int.Parse(Console.ReadLine());
        n = n * n * n;
        Console.WriteLine(n);
        Console.ReadLine();
    }
}
