using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114PRadians
{
    class Program
    {
        static void Main(string[] args)
        {
            string degreesString;
            double degrees;
            Console.Write("Enter an angle in degrees: ");
            degreesString = Console.ReadLine();
            degrees = double.Parse(degreesString);
            Console.WriteLine("Angle converted to radians is " + degrees * 3.14159265359 / 180);
            Console.ReadKey();

        }
    }
}
