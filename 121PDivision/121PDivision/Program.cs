using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121PDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1:0
            //Q2:0.2
            //Q3:0.2
            //Q4:0
            //Q5:integer
            //Q6:0.2
            //Q7:double
            //Q8:
            double a, b, c, root1, root2;
            string userInputA, userInputB, userInputC;
            Console.WriteLine("Enter an A value for the equation y = ax^2 + bx + c");
            userInputA = Console.ReadLine();
            Console.WriteLine("Enter an B value for the equation y = ax^2 + bx + c");
            userInputB = Console.ReadLine(); 
            Console.WriteLine("Enter an C value for the equation y = ax^2 + bx + c");
            userInputC = Console.ReadLine();

            a = double.Parse(userInputA);
            b = double.Parse(userInputB);
            c = double.Parse(userInputC);
            root1 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
            root2 = ((-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
            Console.WriteLine("This is the 1st root: " + root1 + ". This is the 2nd root: " + root2 + ".");
            Console.ReadKey();


        }
    }
}
