using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _138P_Order_using_min_and_max
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int MaxOf3(int a, int b, int c)
        {
            return Math.Max(Math.Max(a,b),c);
        }
        static int MaxOf4(int a, int b, int c, int d)
        {
            return Math.Max(Math.Max(a, b), Math.Max(c, d));
        }
        static int MinOf3(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        static int MinOf4(int a, int b, int c, int d)
        {
            return Math.Min(Math.Min(a, b), Math.Min(c, d));
        }
        static int SecondMaxOf3(int a, int b, int c)
        {
            return Math.Min(Math.Max(a,b), Math.Min(Math.Max(b, c),Math.Max(a,c)));
        }
        static int SecondMinOf3(int a, int b, int c)
        {
            return Math.Min(Math.Max(a, b), Math.Min(Math.Max(b, c), Math.Max(a, c)));
        }
    }
}
