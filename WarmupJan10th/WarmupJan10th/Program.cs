using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupJan10th
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOdds();
            
            Console.ReadLine();
        }
        static void PrintOdds()
        {
            int x = 11;
            while (x <= 99)
            {
                Console.WriteLine(x);
                x = x + 2;
            }
            Console.Write("How are you doing? ");
            string t = Console.ReadLine();
            while (t != "fantastic")
            {
               Console.WriteLine("No you're not!");
               t = Console.ReadLine();
            }
        }
    }
}
