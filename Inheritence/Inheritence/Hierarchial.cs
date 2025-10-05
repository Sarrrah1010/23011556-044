
using System;

public class badar
{
    public void badar1()
    {
        Console.WriteLine("This is father badar");

    }
}
public class Sarah:badar
{
    public void sarah1()
    {
        Console.WriteLine("This is Sarah badar");
        base.badar1();
    }
}
public class Zainab:Sarah
{
    public void zainab1()
    {
        Console.WriteLine("This is zainab badar");

    }
}