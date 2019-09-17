using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;
            Console.WriteLine("Choose Blue, Pink, Green, or Black ");
            color = Console.ReadLine();
            if(color == "Blue" || color== "Pink")
            {
                Console.WriteLine("Please choose 1,2,5 or 6");
                int num;
                num = int.Parse(Console.ReadLine());
                if(num == 2 || num == 6)
                {
                    Console.WriteLine("Please choose 1,2,5, or 6");
                    int num2;
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 == 1)
                    {
                        Console.WriteLine("Find True love");
                    }
                    if (num2 == 2)
                    {
                        Console.WriteLine("Find 20$");
                    }
                    if (num2 == 5)
                    {
                        Console.WriteLine("Get drenched by rain");
                    }
                    if (num2 == 6)
                    {
                        Console.WriteLine("Lose a friend");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please choose 3,4,7, or 8");
                    int num2;
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 == 3)
                    {
                        Console.WriteLine("Get flowers");
                    }
                    if (num2 == 4)
                    {
                        Console.WriteLine("Find Blueberries");
                    }
                    if (num2 == 7)
                    {
                        Console.WriteLine("Get a bad grade");
                    }
                    if (num2 == 8)
                    {
                        Console.WriteLine("Break your phone");
                    }
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Please choose 3,4,7, or 8");
                int num;
                num = int.Parse(Console.ReadLine());
                if (num == 3 || num == 7)
                {
                    Console.WriteLine("Please choose 1,2,5, or 6");
                    int num2;
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 == 1)
                    {
                        Console.WriteLine("Find True love");
                    }
                    if (num2 == 2)
                    {
                        Console.WriteLine("Find 20$");
                    }
                    if (num2 == 5)
                    {
                        Console.WriteLine("Get drenched by rain");
                    }
                    if (num2 == 6)
                    {
                        Console.WriteLine("Lose a friend");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please choose 3,4,7, or 8");
                    int num2;
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 == 3)
                    {
                        Console.WriteLine("Get flowers");
                    }
                    if (num2 == 4)
                    {
                        Console.WriteLine("Find Blueberries");
                    }
                    if (num2 == 7)
                    {
                        Console.WriteLine("Get a bad grade");
                    }
                    if (num2 == 8)
                    {
                        Console.WriteLine("Break your phone");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
