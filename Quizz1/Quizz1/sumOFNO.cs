using System;
public class sum 
{
public void SUMOFNO()
    {
        int s = 0;
        Console.WriteLine("Enter the number");
        int n=int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            s = s + i;
          
        }
        Console.WriteLine(s);
        Console.ReadLine();
    }
        }
