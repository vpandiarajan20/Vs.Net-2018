using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _302._2PEnterPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            bool isTooShort = true;
            bool containsNumber = false;

            Console.WriteLine("Please enter a password at least 8 characters long and 1 numeral");
            password = Console.ReadLine();
            bool contains1 = password.Contains("1");
            bool contains2 = password.Contains("2");
            bool contains3 = password.Contains("3");
            bool contains4 = password.Contains("4");
            bool contains5 = password.Contains("5");
            bool contains6 = password.Contains("6");
            bool contains7 = password.Contains("7");
            bool contains8 = password.Contains("8");
            bool contains9 = password.Contains("9");
            bool contains0 = password.Contains("0");
            if (contains1 == true || contains2 == true || contains3 == true || contains4 == true || contains5 == true || contains6 == true || contains7 == true || contains8 == true || contains9 == true || contains0 == true)
                containsNumber = true;
            if (password.Length >= 8)
            {
                isTooShort = false;
            }
            while (isTooShort == true || containsNumber == false)
            {
                Console.WriteLine("Enter another password");
                password = Console.ReadLine();
                contains1 = password.Contains("1");
                contains2 = password.Contains("2");
                contains3 = password.Contains("3");
                contains4 = password.Contains("4");
                contains5 = password.Contains("5");
                contains6 = password.Contains("6");
                contains7 = password.Contains("7");
                contains8 = password.Contains("8");
                contains9 = password.Contains("9");
                contains0 = password.Contains("0");
                if (contains1 == true || contains2 == true || contains3 == true || contains4 == true || contains5 == true || contains6 == true || contains7 == true || contains8 == true || contains9 == true || contains0 == true)
                    containsNumber = true;
                if (password.Length > 8)
                {
                    isTooShort = false;
                }
            }
            Console.WriteLine("You're done");
            Console.ReadKey();
        }
    }
}
