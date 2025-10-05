using System;

public class ObjectCounter
{
    // static variable sab objects ke liye common hai
    static int count = 0;

    // constructor — har object banne par count badh jaayega
    public ObjectCounter()
    {
        count++;
    }

    // static method jo total count dikhata hai
    public static void ShowCount()
    {
        Console.WriteLine("Total objects created: " + count);
    }
}
