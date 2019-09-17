using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _156P___Checking_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number is " + GetIntBetween(5, 13));
            Console.WriteLine("The number is " + GetIntBetween(5, 13));
            Console.WriteLine("The number is " + GetIntBetween(5, 13));
            Console.ReadLine();
        }
        static int GetIntBetween (int minValue, int maxValue)
        {
            string userInput;
            int num;
            userInput = Console.ReadLine();
            num = int.Parse(userInput);
            if (num > maxValue)
                return maxValue;
            else if (num < minValue)
                return minValue;
            else
                return num;
        }
    }
}
