using System;

public class GrandFather
{
    public void display()
    {
        Console.WriteLine("this is grandfather");
    }
}
public class Father:GrandFather
{
    public void displayFather()
    {
        Console.WriteLine("this is father");
    }
}
public class Child:Father
{
    public void Show()
    {
        Console.WriteLine("this is CHILD");
    }
}