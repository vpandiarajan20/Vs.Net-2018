using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan30th
{
    class Program
    {
        static void Main()
        {
            int high = 50;
            for (int i = 1; i < high; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadKey();
        }
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

    }
}
