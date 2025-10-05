using System;
/*Create a class Employee with a virtual method Work().
Derive classes Manager and Developer that override the method.
Call them polymorphically (e.g., Employee emp = new Manager(); emp.Work();).

---*/

public class Employee
{
    public static void Work()
    {

    }
}
public class Manager : Employee
{

}
public class Developer : Employee 
{
}
