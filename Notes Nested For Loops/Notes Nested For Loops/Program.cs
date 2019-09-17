using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Nested_For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Column Header
            Console.WriteLine("  12345678910");
            for(int row = 1; row<=10; row++)
            {
                //row header
                Console.Write(row + "\t");
                //table values
                for (int col = 1; col <= 10; col++)
                    Console.Write(row * col + "\t");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        static string PadLeft(int num, int spaces)
        {
            //PL(15,5)
            string returnVal = "" + num;
            for (int i = 0; i <= spaces; i++)
                returnVal = "" + returnVal;
            return returnVal;
        }
    }
}
