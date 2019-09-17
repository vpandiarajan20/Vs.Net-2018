using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149A_Reading_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("x2");
            if (n % 3 == 0)
                Console.WriteLine("x3");
            if (n % 5 == 0)
                Console.WriteLine("x5");
            if (n % 3 != 0 && n % 3 != 0 && n % 5 != 0)
                 Console.WriteLine("Prime");
            Console.ReadKey();

        }
    }
}
