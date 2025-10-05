
using System;

public class GradeEvaluator
{
    public void EvaluateGrade()
    {
        Console.Write("Enter marks (0–100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 85 && marks <= 100)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 70 && marks <= 84)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 55 && marks <= 69)
        {
            Console.WriteLine("Grade: C");
        }
        else if (marks >= 40 && marks <= 54)
        {
            Console.WriteLine("Grade: D");
        }
        else if (marks >= 0 && marks < 40)
        {
            Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid marks. Please enter a value between 0 and 100.");
        }

        Console.ReadLine();
    }
}
