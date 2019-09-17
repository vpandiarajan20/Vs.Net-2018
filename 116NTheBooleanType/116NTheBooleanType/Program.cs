using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _116NTheBooleanType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare all variables at the beginning
            string myName = "Alrfred", yourName = "Beatrice";
            bool isA, isB;
            isA = (yourName == "Alfred");
            isB = (myName != "Beatrice");
            Console.WriteLine("Do you think isA is T or F? isB T or F?");
            Console.WriteLine("(Press enter to continue)");
            Console.ReadKey();

            Console.WriteLine("isA is " + isA + " and isB is " + isB + ".");
            Console.WriteLine("(Press enter to continue)");
            Console.ReadKey();

            //Declare variables
            int myAge = 40;
            isA = (myAge > 50);
            isB = (myAge <= 40);
            Console.WriteLine("Do you think isA is T or F? isB T or F?");
            Console.WriteLine("(Press enter to continue)");
            Console.ReadKey();
            Console.WriteLine("isA is " + isA + " and isB is " + isB + ".");
            Console.WriteLine("(Press enter to exit)");
            Console.ReadKey();

        }
    }
}
