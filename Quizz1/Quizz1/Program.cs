using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EVENorODD a= new EVENorODD();
              a.EvenOrOdd();
            sum b = new sum();
            b.SUMOFNO();
            cube c=new cube();  
            c.CUBEOFNO();
            overload d=new  overload();
            d.display();
            d.display("sarah", "badar");
            Calculatorss e=new Calculatorss();
            e.Calculator();
            Sample f= new Sample();
            f.addnum();
            f.addnum();
            f.display();
            Student s = new Student();
            s.name = "Ali";
            s.age = 21;
            s.rollno = 1001;

            Console.WriteLine("Name: " + s.name);
            Console.WriteLine("Age: " + s.age);
            Console.WriteLine("Roll No: " + s.rollno);*/
            Animal a;
            a = new Dog();
            a.Sound();

            a = new Cat();
            a.Sound();




        }
    }
}
