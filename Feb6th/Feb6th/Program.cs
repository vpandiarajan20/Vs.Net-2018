using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //What can we do with variables?
            // 1. Declare. "What data type?"
            // int, bool, double, string
            int number;
            string name, name2;

            // 2. Assign. Giving it a value.
            number = 12;
            name = "Jimmy";

            // 3. Initialize. Declare +Assign 
            int n = 3;

            // 4. Reassign. Assign again. OVERWRITES!
            n = 7;

            // 5. Use the variable.
            Console.WriteLine("His name is " + name);
            int answer = 7 * n + 8;

            // Arrays allow us to store many values.
            // 1. Declare. "Type" AND "Size"
            string[] names;
            int[] numbers = new int[100];
            names = new string[36];

            // 2. Assign. Give values to array.
            names[0] = "Amrutha";
            names[35] = "Vignesh";
            names[30] = "Sid";

            // 3. Initialize.
            // Less common / kindof scrub way:
            double[] gpa = { 1.23, 4.56, 3.12 };
            // Usual way
            double[] height = new double[100];
            for (int i = 0; i < height.Length; i++)
                height[i] = 0;

            // 4. Reassign
            gpa[0] = 3.21;
            names[1] = names[0];
            names[0] = "Akshar";

            // 5. Use the values
            Console.WriteLine("You raised your GPA to " + gpa[0] + "!!!");
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine("Student# " + (i + 1) + ":\t" + names[i]);

            // Part 1: Fill in an array with the values 1-100
            int[] values = new int[100];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = i + 1;
            }
            // Part 2: Print out all the contents of the array.
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.ReadLine();
        }
    }
}


