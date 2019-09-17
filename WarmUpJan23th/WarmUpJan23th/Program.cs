using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpJan23th
{
    class Program
    {
        static void Main(string[] args)
        {
            StarTriangle(5);
            Console.ReadLine();
        }
        static void SumEvensBetween(int low, int high)
        {
            int z = 0;
            if (low/2*2==low) 
            {
                for(int a = low; a<=high; a = a+2 )
                {
                    z = z + a;
                }
            }
            else
            {
                for (int a = low + 1; a<=high; a = a+2)
                {
                    z = z + a;
                }
            }
            Console.Write(z);
            
        }
        static void Add(int x, int y)
        {
            int z = 0;
            for(int a = x; a<=y; a++)
            {
                z = z + a;
            }
            Console.Write(z);
        }
        static void CountOddsBetween(int low, int high)
        {
            int x = 0;
            for(int a = low; a<= high; a++)
            {
                if (a/2 != a)
                    x++;
            }
            Console.WriteLine(x);
        }
        static void PrintStars(int num)
        {
            string x = "";
            for (int a = 0; a < num; a++)
            {
                x = x + "*";
            }
            Console.WriteLine(x);
        }
        static void StarTriangle(int num)
        {
            for (int row = num; row <= 8; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int row = num; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
