using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to find the area of a triangle, square, or a rectangle?");
            string userInput = Console.ReadLine();
            double b, height, side, length, width;
            if (userInput.ToLower() == "triangle")
            {
                Console.WriteLine("Input base:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Input height:");
                height = double.Parse(Console.ReadLine());
                AreaTriangle(b, height);
            }
            if (userInput.ToLower() == "rectangle")
            {
                Console.WriteLine("Input width:");
                width = double.Parse(Console.ReadLine());
                Console.WriteLine("Input length:");
                length = double.Parse(Console.ReadLine());
                AreaRectangle(length, width);
            }
            if (userInput.ToLower() == "square")
            {
                Console.WriteLine("Input side:");
                side = double.Parse(Console.ReadLine());
                AreaSquare(side);
            }
                
        }
        static double AreaTriangle(double b, double height)
        {
            return b*height/2;
        }
        static double AreaRectangle(double length, double width)
        {
            return width * length;

        }
        static double AreaSquare(double side)
        {
            return side * side;
        }
    }
}
