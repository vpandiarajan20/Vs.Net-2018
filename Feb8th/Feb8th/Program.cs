using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb8th
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Store -1 to -200
            int[] negatives = new int[200]; //0-199
            for (int i = 0; i < 200; i++)
                negatives[i] = (-1 * i) - 1;
            for (int i = 0; i < 200; i++)
                Console.WriteLine(negatives[i]);
            // 2. Store the numbers 48 to 84
            int[] numbers = new int[37]; //0-36
            for (int i = 0; i < 37; i++)
                numbers[i] = 48 + i;
            for (int i = 0; i < 37; i++)
                Console.WriteLine(numbers[i]);
            // 3. Store the first 500 even numbers.
            int[] evens = new int[500]; //0-499
            for (int i = 0; i <= 499; i++)
            {
                evens[i] = i * 2;
            }
            for (int i = 0; i <= 499; i++)
            {
                Console.WriteLine(evens[i]);
            }
            // 4. Store the first 300 odd numbers.
            int[] odds = new int[300]; //0-299
            for (int i = 0; i < 300; i++)
            {
                odds[i] = (2 * i) + 1;
            }
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine(odds[i]);
            }
            // 5. Store the first 50 Fibonacci numbers.
            int[] fibonnaci = new int[50];//0-49
            for (int i = 0; i <= 49; i++)
                fibonnaci[i] = fib(i);
            for (int i = 0; i <= 49; i++)
                Console.WriteLine(fibonnaci[i]);
            Console.ReadKey();
        }
        static int fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n - 2);
        }
    }
}



