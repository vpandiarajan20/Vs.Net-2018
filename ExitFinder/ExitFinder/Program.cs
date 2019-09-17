using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            int exitX = 2, exitY = 1;
            string userInput;
            while (x != exitX || y != exitY)
            {
                Console.Write("> ");
                userInput = Console.ReadLine();
                if(userInput == "up")
                {
                    y++;
                }
                if(userInput == "down")
                {
                    y--;
                }
                if (userInput == "left")
                {
                    x--;
                }
                if (userInput == "right")
                {
                    x++;
                }
                if (userInput == "where is the exit?")
                {
                    Console.WriteLine(exitX + "," + exitY);
                }
                if (userInput == "Where am I?")
                {
                    Console.WriteLine(x + "," + y);
                }

            }
            Console.Write("Congratulations! You made it out alive");
            Console.ReadLine();
        }
    }
}
