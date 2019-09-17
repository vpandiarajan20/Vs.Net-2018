using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119PBooleanChecklist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            string userInput = "";
            int num = 0;
            bool isGreater99, isLess10, isEven, isOdd;

            // User Input
            Console.Write("Enter a 2 digit positive integer: ");
            userInput = Console.ReadLine();
            
            // Analysis
            num = int.Parse(userInput);
            isGreater99 = (num > 99);
            isLess10 = (num < 10);
            isEven = (num / 2 * 2 == num);
            isOdd = (num / 2 * 2 != num);
            
            //Report
            Console.WriteLine("Greater than 99:\t\t" + isGreater99 + "\nLess than 10:\t\t\t" + isLess10 + "\nEven:\t\t\t\t" + isEven + "\nOdd:\t\t\t\t" + isOdd + "\n(Press enter to continue)\n");
            Console.ReadKey();

            // User Input
            Console.Write("Enter a 2 digit positive integer: ");
            userInput = Console.ReadLine();

            // Analysis
            num = int.Parse(userInput);
            isGreater99 = (num > 99);
            isLess10 = (num < 10);
            isEven = (num / 2 *2 == num);
            isOdd = (num / 2 * 2 != num);

            //Report
            Console.WriteLine("Greater than 99:\t\t" + isGreater99 + "\nLess than 10:\t\t\t" + isLess10 + "\nEven:\t\t\t\t" + isEven + "\nOdd:\t\t\t\t" + isOdd + "\n(Press enter to continue)\n");
            Console.ReadKey();

            // User Input
            Console.Write("Enter a 2 digit positive integer: ");
            userInput = Console.ReadLine();

            // Analysis
            num = int.Parse(userInput);
            isGreater99 = (num > 99);
            isLess10 = (num < 10);
            isEven = (num / 2 * 2 == num);
            isOdd = (num / 2 * 2 != num);

            //Report
            Console.WriteLine("Greater than 99:\t\t" + isGreater99 + "\nLess than 10:\t\t\t" + isLess10 + "\nEven:\t\t\t\t" + isEven + "\nOdd:\t\t\t\t" + isOdd + "\n(Press enter to exit)\n");
            Console.ReadKey();
        }
    }
}
