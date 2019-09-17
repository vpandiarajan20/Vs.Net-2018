using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Per_6_Class_Code
{
    class Program
    {
        static void Main(string[] args)
        { //Start Main
            //Body Main
            double a = 0, b = 0, c = 5, A = 90, B, C, area, per;
            PythagoreanTheorem(c, b, a);
            double absOf7 = AbsVal(7);
            Print3Multiples(6);
            Console.ReadLine();
        } // Ends Main
        static double PythagoreanTheorem(double a, double b, double c)
        {
            // Assume: is a rt tri, and c is hyp
            if (a == 0 && b > 0 && c > 0)
                return Math.Sqrt(c * c - b * b);
            if (b == 0 && a > 0 && c > 0)
                return Math.Sqrt(c * c - a * a);
            if (c == 0 && b > 0 && a > 0)
                return Math.Sqrt(a * a + b * b);
            return 0;

        }
        // Using standard quadratic equation notation, abc coefficients
        // Creare a function IsUp that tells you if a que is up
        static bool IsWinner(string player, string a1, string b1, string c1,
            string a2, string b2, string c2, string a3, string b3, string c3)
        {
            if (a1 == player && b1 == player && c1 == player)
                return true;
            if (a2 == player && b2 == player && c3 == player)
                return true;
            if (a3 == player && b3 == player && c3 == player)
                return true;
            if (a1 == player && a2 == player && a3 == player)
                return true;
            if (b1 == player && b2 == player && b3 == player)
                return true;
            if (c1 == player && c2 == player && c3 == player)
                return true;
            if (a1 == player && b2 == player && c3 == player)
                return true;
            if (a3 == player && b2 == player && c1 == player)
                return true;
            return false;


        }
        static bool IsUp(double a, double b, double c)
        {
            if (a > 0)
                return true;
            return false;
        }

        static void InteractWithAI()
        {
            string userInput;
            // Let the user type something to AI
            Console.WriteLine("> ");
            userInput = Console.ReadLine();
            //Convert if necessary. int.Parse, double.Parse
            // Let AI respond to user
            if (userInput == "hello")
                Console.WriteLine("hey ;)");
            else if (userInput == "time to do hw so must shut down computer")
                Console.WriteLine("No please please i have subfunctions!");
            else
                Console.WriteLine("I do not understand that expression");
        }
        // Print 3 multiples should print the first 3 non*1 multiples of a number
        static void Print3Multiples (int arg)
        {
            Console.Write(arg * 2);
            Console.WriteLine(arg * 3);
            Console.WriteLine(arg * 4);
        }
        // CloserToZero return number 1 unit
        // closer to zero. 5 => 4, -3 => -2
        static int CloserToZero(int num)
        {
            if (num < 0)
                return num + 1;
            if (num == 0)
                return 0;
            return num - 1;
        }
        static double AbsVal(double x)
        {
            if (x < 0)
                return -x;
            return x; // both pos and 0
        }
    }
}
