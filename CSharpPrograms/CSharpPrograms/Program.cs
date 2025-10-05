using System;

namespace CSharpPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinMax obj1 = new MinMax();
            obj1.FindMinMax(); 

            EvenOrOdd obj2 = new EvenOrOdd();
            obj2.CheckEvenOdd(); 

            Calculatorss obj3 = new Calculatorss();
            obj3.Calculator();

            Factorial obj4 = new Factorial();
            obj4.FactorialCalci();

            Reverse obj5 = new Reverse();
            obj5.ReverseNumbers();
            Table obj6= new Table();
            obj6.TableOfN();
            Sum obj7 = new Sum();
            obj7.SumNumbers();
            Console.WriteLine("Testing Git connection!");
            EvenOdd obj8 = new EvenOdd();
            obj8.EvenOrOddArray();

            SearchElement obj9 = new SearchElement();
            obj9.SearchElementArray();

            GradeEvaluator obj10 = new GradeEvaluator();
             obj10.EvaluateGrade();
        }
    }
}
