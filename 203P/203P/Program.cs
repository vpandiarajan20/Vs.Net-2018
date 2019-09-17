using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _203P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number is " + GetIntBetween(5, 13));
            Console.ReadLine();
        }
        static int GetIntBetween(int minValue, int maxValue)
        {
            Console.WriteLine("Enter an integer between " + minValue + " and " + maxValue + ":");
            int x = int.Parse(Console.ReadLine());
            while (x > maxValue || x < minValue)
            {
                Console.WriteLine("Enter an integer between " + minValue + " and " + maxValue + ":");
                x = int.Parse(Console.ReadLine());
            }
            return x;
        } 
    }
}
