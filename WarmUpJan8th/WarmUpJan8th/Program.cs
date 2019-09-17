using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpJan8th
{
    class Program
    {
        static void Main(string[] args)
        {
            SumBetween(3, 5);
            Console.ReadLine();
        }
        static void SumBetween(int lower, int higher)
        {
            int x = 0;
            while(lower <= higher)
            {
                x = lower + x;
                lower++;
            }
            Console.Write(x);
        }
    }
}
