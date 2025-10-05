using System;

public class SearchElement
{
    public void SearchElementArray()
    {
        int[] numbers = new int[10];
        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Number i + 1: ");
            numbers[i] = int.Parse(Console.ReadLine());


            Console.Write(" a number to search: ");
            int searchNum = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int j = 0; j < numbers.Length; j++)
            {

                if (numbers[j] == searchNum)

                    Console.WriteLine("Number found at position {j + 1}.");
                found = true;
                break;
            }
        }
    }
    
           
    
}
