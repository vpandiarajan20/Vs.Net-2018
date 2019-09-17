using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_and_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Power(3, 5);
            int b = Factorial(5);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
        static int Power(int b, int p)
        {
            int number = 1;
            for(int x = 0; x<p; x++)
                number = number * b;
            return number;
        }
        static int Factorial(int n)
        {
            int number = 1;
            for(int x=1; x<=n; x++)
                number = x * number;
            return number;
        }
    }
}
