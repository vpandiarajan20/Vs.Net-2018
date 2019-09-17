using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207P
{
    class Program
    {
        static void Main(string[] args)
        {
            double dailyWage = 0;
            double total = 0;
            double wage = .005;
            double tota = 0;
            for (int day = 1; day <= 31; day++)
            {
                dailyWage = dailyWage + .01;
                total = dailyWage + total;
                if (day == 31)
                {
                    Console.WriteLine(dailyWage);
                    Console.WriteLine(total);
                }
                wage = wage * 2;
                tota = wage + tota;
                if (day == 31)
                {
                    Console.WriteLine(wage);
                    Console.WriteLine(tota);
                }
            }
            
            Console.WriteLine("My last daily wage was " + dailyWage);
            Console.WriteLine("My total balance is " + total);
            Console.WriteLine("My last daily wage was " + wage);
            Console.WriteLine("My total balance is " + tota);
            for (int x = 1; x < 13; x++)
            {
                Console.Write("*" + x + "*");
            }
                Console.ReadKey();
        }
    }
}
