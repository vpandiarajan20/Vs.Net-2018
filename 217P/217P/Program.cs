using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217P
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int c = 1; c < row; c++)
                    Console.Write(c);
                Console.WriteLine(row);
            }
            Console.WriteLine("");
            for (int row = 1; row <= 5; row++)
            {
                for (int c = row; c <= 5; c++)
                    Console.Write(c);
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int row = 5; row >= 1; row--)
            {
                for (int c = row; c >= 1; c--)
                    Console.Write(c);
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int row = 5; row >= 1; row--)
            {
                for (int c = 5; c >= row; c--)
                    Console.Write(c);
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
