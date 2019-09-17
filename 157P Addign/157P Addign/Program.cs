using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _157P_Addign
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            score = score + Question();
            Console.WriteLine("Your score is " + score);
            Console.ReadLine();
        }
        static int Question()
        {
            Random rng = new Random();
            int pointsEarned = 0;
            int randomNumber1 = rng.Next(10, 100);
            int randomNumber2 = rng.Next(10, 100);
            int answer = randomNumber1 + randomNumber2;
            Console.WriteLine ("What is " + randomNumber1 + " + " + randomNumber2 + "?");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            if (number == answer)
            {
                pointsEarned++;
            }
            else
                pointsEarned = pointsEarned - 1;
            return pointsEarned;

        }
    }
}
