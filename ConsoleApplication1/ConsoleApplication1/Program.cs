using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Call the get number function and 
            // print out what they entered.
            // if the user entered 5, also print out
            // "Hey, that's my favorite number too!"
            string returnVal = UserInput();
            Console.WriteLine(returnVal);
            if (returnVal == "User entered 5")
                Console.WriteLine("Hey, that's my favorite number too!");

            Console.ReadLine();
        }
        // 1. Create a function that gets a number from 
        // the user, and returns a string saying 
        // "User entered ___"
        static string UserInput()
        {
            Console.WriteLine("Enter a number");
            string returnVal = ("User entered " + Console.ReadLine());
            return returnVal;
        }
    }
}
