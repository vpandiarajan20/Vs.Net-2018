using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmpUpJan7
{
    class Program
    {
        static void Main(string[] args)
        {
            SumBetween(1, 3);
            Console.ReadLine();
        }
        static void SumBetween(int lower,int upper)
        {
            int total = 0;
           
            while(lower <= upper)
            {
                total = lower + total;
                lower++;
            }
            Console.Write(total);
        }
    }
}
