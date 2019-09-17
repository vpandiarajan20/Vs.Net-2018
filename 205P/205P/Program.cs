using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205P
{
    class Program
    {
        static void Main(string[] args)
        {
            Part6();
            Part7(5);
            Console.Read();
        }
        static void Part0()
        {
            for(int i = 0; i<= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Part1()
        {
            for (int i = 0; i <= 100; i = i+2)
            {
                Console.WriteLine(i);
            }
        }
        static void Part2()
        {
            for (int i = 1; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        static void Part3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(9*i);
            }
        }
        static void Part4()
        {
            for (int i = 2; i <= 2048; i = 2*i)
            {
                Console.WriteLine(i);
            }
        }
        static void Part5()
        {
            int x = 2;
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(2 * i - 1 + "\t" + (13*i) + "\t" + x);
                x = x * 2;
            }
        }
        static void Part6()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
                if (i == 25)
                    Console.WriteLine("Almost THERE");
            }
        }
        static void Part7(int num)
        {
            for(int i = 0; i<=num; i++)
            {
                Console.Write("*");
            }
        }
    }
}
