using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Period_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //  2. Enter a number, and print "EVEn"
            // or "ODD" depending on value entered.
            int userInput;
            userInput = int.Parse(Console.ReadLine());
            if (IsEven(userInput) == true)
                Console.WriteLine("EVEN");
            else
                Console.WriteLine("FALSE");

            // 4. Get a QE from user, ie, a,b,c
            // And display There are __ roots.
            int a, b, c;
            Console.WriteLine("What is the A value?");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the B value?");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the C value?");
            c = int.Parse(Console.ReadLine()); 

            Console.WriteLine("There are " + RealRoots(a, b, c) + "roots.");
        }
        // 1. Create a function called IsEven
        // that takes as argument an integer
        // and returns whether or not it is even
        static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
        // 3. Create a function that tells yhou the 
        // number of roots of a quadratic equation
        // y = ax2 + bx + c, use discriminant
        // bb - 4ac
        static int RealRoots(int a, int b, int c)
        {
            if (b * b - 4 * a * c > 0)
                return 2;
            if (b * b - 4 * a * c == 0)
                return 1;
            else
                return 0;

        }
    }
}
