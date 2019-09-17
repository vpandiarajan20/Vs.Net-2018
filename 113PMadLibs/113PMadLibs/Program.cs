using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113PMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            string name, adjective1, adjective2, nouns, place, verbMovement, verbPast, number1String, number2String;
            int number1, number2;

            //User Inputs
            Console.WriteLine("Type a name.");
            name = Console.ReadLine();

            Console.WriteLine("Type an adjective.");
            adjective1 = Console.ReadLine();

            Console.WriteLine("Type an adjective.");
            adjective2= Console.ReadLine();

            Console.WriteLine("Type a plural noun.");
            nouns = Console.ReadLine();

            Console.WriteLine("Type a place.");
            place = Console.ReadLine();

            Console.WriteLine("Type a verb(movement past tense).");
            verbMovement = Console.ReadLine();

            Console.WriteLine("Type a verb in the past tense.");
            verbPast = Console.ReadLine();

            Console.WriteLine("Type a number greater than one.");
            number1String = Console.ReadLine();

            Console.WriteLine("Type a number greater than one.");
            number2String = Console.ReadLine();

            // String to integer conversion
            number1 = int.Parse(number1String);
            number2 = int.Parse(number2String);

            //Story
            Console.Write("Once upon a time there was a man named [" + name + "]. He was a very [" + adjective1 + "] and [" + adjective2 + "] man. He had [" + number1 +"] [" + nouns + "]. He bought these [" + nouns + "] at [" + place + "]. Then he [" + verbMovement + "] over to his friend's house. He had [" + number2 + "] friends. There they [" + verbPast + "] all day.");
            
            Console.ReadKey();
        }
    }
}
