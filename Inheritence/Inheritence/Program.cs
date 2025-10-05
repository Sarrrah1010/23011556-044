using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*Child child = new Child();
            Father child2 = new Father();
            child.display();
            child.Show();
            child2.display();
            Father papa = new Father();
            papa.display();
            Child ch1 = new Child();
            ch1.display();
            ch1.displayFather(); //----------------*/
           /* Sarah s=new Sarah();
            s.sarah1();
            Console.WriteLine("-----");
            Zainab z = new Zainab();
            z.sarah1(); //-------*/
           /*Child11 Child1 = new Child11();
            Child1.Show11(); //--------
           dog d= new dog();
            d.displayconstructor();
            cat c = new cat();
            c.displayconstructor2();*/
            // 3 objects ban rahe hain
            ObjectCounter obj1 = new ObjectCounter();
            ObjectCounter obj2 = new ObjectCounter();
            ObjectCounter obj3 = new ObjectCounter();

            // total count print karna
            ObjectCounter.ShowCount();
        }

    }
    
}
