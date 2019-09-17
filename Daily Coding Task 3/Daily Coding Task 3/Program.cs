using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Coding_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pswrd = Password();
            if (Pswrd.Length < 8)
                Pswrd = Password();
            if (Pswrd.Length < 8)
                Pswrd = Password();
            if (Pswrd.Length < 8)
                Console.WriteLine("Error: Account creation failed.");

            // 2. In Main(), check to see if the password
            // is at least 8 characters long
            // They get 3 tries to enter a valid password, and if they fail,\
            // print out "Error: Account creation failed."

            Console.ReadLine();
        }
        // 1. Create a function that gets a password from the user
        static string Password()
        {
            Console.WriteLine("Provide a password with at least 8 characters");
            return Console.ReadLine();
        }
    }
}
