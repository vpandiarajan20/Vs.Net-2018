using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVHS;

namespace _132PTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string a1 = " ", a2 = " ", a3 = " ";
            string b1 = " ", b2 = " ", b3 = " ";
            string c1 = " ", c2 = " ", c3 = " ";
            string currentTurn = "X";
            string userInput = "";

            /* The board looks like this:
             *    A1 B1 C1
             *    A2 B2 C2
             *    A3 B3 C3 */

            Console.WriteLine("Welcome to TicTacToe"); // FIX!!!

            // The main turns loop. Continues as long as nobody won and there is space available.
            while (IsWinner("X", a1, b1, c1, a2, b2, c2, a3, b3, c3) == false
                && IsWinner("O", a1, b1, c1, a2, b2, c2, a3, b3, c3) == false
                && CountOnBoard(" ", a1, b1, c1, a2, b2, c2, a3, b3, c3) > 0 == true)
            {
                // Description
                Console.WriteLine("\n\n\nIt's player " + currentTurn + "'s turn.");
                Console.WriteLine("This is the current board.");
                PrintBoard(a1, b1, c1, a2, b2, c2, a3, b3, c3); // IMPLEMENT!!!

                // Turn choice, user input
                Console.WriteLine("\nChoose an available number."); // FIX!!!
                PrintBoardWithNumbers(a1, b1, c1, a2, b2, c2, a3, b3, c3);
                Console.Write("Pick a number: "); // FIX!!!
                userInput = Console.ReadLine();

                // Depending on input, do it or repeat current player's turn.
                if (IsAvailable(userInput, a1, b1, c1, a2, b2, c2, a3, b3, c3))
                {
                    DVHS.TTT.UpdateLocationValue(userInput, currentTurn, ref a1, ref b1, ref c1, ref a2, ref b2, ref c2, ref a3, ref b3, ref c3);
                    // Change turns
                    if (currentTurn == "X")
                        currentTurn = "O";
                    else
                        currentTurn = "X";
                }
                else
                {
                    Console.WriteLine("Invalid Spot! Try again."); // FIX!!!
                }
            } // End While loop

            // Determine winner
            if (IsWinner("X", a1, b1, c1, a2, b2, c2, a3, b3, c3))
                Console.WriteLine("X wins!!!"); // FIX!!!
            else if (IsWinner("O", a1, b1, c1, a2, b2, c2, a3, b3, c3))
                Console.WriteLine("O wins!!!"); // FIX!!!
            else
                Console.WriteLine("Cats Game!"); // FIX!!!

            Console.WriteLine("Press Enter to quit"); // FIX!!!
            Console.ReadLine();
        }
        static void PrintBoard(string a1, string b1, string c1, string a2, string b2, string c2, string a3, string b3, string c3)
        {
            if (a1 == "")
                a1 = "1";
            if (a2 == "")
                a2 = "2";
            if (a3 == "")
                a3 = "3";
            if (b1 == "")
                b1 = "4";
            if (b2 == "")
                b2 = "5";
            if (b3 == "")
                b3 = "6";
            if (c1 == "")
                c1 = "7";
            if (c2 == "")
                c2 = "8";
            if (c3 == "")
                c3 = "9";
            Console.WriteLine(a1 + " | " + b1 + " | " + c1);
            Console.WriteLine("---------");
            Console.WriteLine(a2 + " | " + b2 + " | " + c2);
            Console.WriteLine("---------");
            Console.WriteLine(a3 + " | " + b3 + " | " + c3);
        }
        static int CountOnBoard(string player, string a1, string b1, string c1, string a2, string b2, string c2, string a3, string b3, string c3)
        {
            int returnValue = 0;
            if (a1 == player)
                returnValue++;
            if (a2 == player)
                returnValue++;
            if (a3 == player)
                returnValue++;
            if (b1 == player)
                returnValue++;
            if (b2 == player)
                returnValue++;
            if (b3 == player)
                returnValue++;
            if (c1 == player)
                returnValue++;
            if (c2 == player)
                returnValue++;
            if (c3 == player)
                returnValue++;
            return returnValue;

        }
        static void PrintBoardWithNumbers(string a1, string b1, string c1, string a2, string b2, string c2, string a3, string b3, string c3)
        {
            if (a1 == " ")
                Console.Write(1);
            else
                Console.Write(a1);
            Console.Write(" | ");
            if (b1 == " ")
                Console.Write(2);
            else
                Console.Write(b1);
            Console.Write(" | ");
            if (c1 == " ")
                Console.WriteLine(3);
            else
                Console.WriteLine(c1);
            Console.WriteLine("---------");
            if (a2 == " ")
                Console.Write(4);
            else
                Console.Write(a2);
            Console.Write(" | ");
            if (b2 == " ")
                Console.Write(5);
            else
                Console.Write(b2);
            Console.Write(" | ");
            if (c2 == " ")
                Console.WriteLine(6);
            else
                Console.WriteLine(c2);
           
            Console.WriteLine("---------");
            if (a3 == " ")
                Console.Write(7);
            else
                Console.Write(a3);
            Console.Write(" | ");
            if (b3 == " ")
                Console.Write(8);
            else
                Console.Write(b3);
            Console.Write(" | ");
            if (c3 == " ")
                Console.WriteLine(9);
            else
                Console.WriteLine(c3);

        }
        static int TurnsRemaining(string a1, string b1, string c1, string a2, string b2, string c2, string a3, string b3, string c3)
        {
            int returnValue = 0;
            if (a1 == " ")
                returnValue= returnValue+ 1;
            if (a2 == " ")
                returnValue = returnValue + 1;
            if (a3 == " ")
                returnValue = returnValue + 1;
            if (b1 == " ")
                returnValue = returnValue + 1;
            if (b2 == " ")
                returnValue = returnValue + 1;
            if (b3 == " ")
                returnValue = returnValue + 1;
            if (c1 == " ")
                returnValue = returnValue + 1;
            if (c2 == " ")
                returnValue = returnValue + 1;
            if (c3 == " ")
                returnValue= returnValue+ 1;
            return returnValue;
        }
        static bool IsAvailable(string position, string a1, string b1, string c1, string a2, string b2, string c2, string a3, string b3, string c3)
        {
            bool returnValue = false;
            if (position == "1" && a1 == " ")
                returnValue = true;
            if (position == "4" && a2 == " ")
                returnValue = true;
            if (position == "7" && a3 == " ")
                returnValue = true;
            if (position == "2" && b1 == " ")
                returnValue = true;
            if (position == "5" && b2 == " ")
                returnValue = true;
            if (position == "8" && b3 == " ")
                returnValue = true;
            if (position == "3" && c1 == " ")
                returnValue = true;
            if (position == "6" && c2 == " ")
                returnValue = true;
            if (position == "9" && c3 == " ")
                returnValue = true;
            return returnValue;
        }
        static bool IsWinner(string player, string a1, string b1, string c1, string a2, string b2, string c2, string a3, string b3, string c3)
        {
            bool returnValue = false;
            if (player == a1 && player == a2 && player == a3)
                returnValue = true;
            if (player == b1 && player == b2 && player == b3)
                returnValue = true;
            if (player == c1 && player == c2 && player == c3)
                returnValue = true;
            if (player == a1 && player == b1 && player == c1)
                returnValue = true;
            if (player == a2 && player == b2 && player == c2)
                returnValue = true;
            if (player == a3 && player == b3 && player == c3)
                returnValue = true;
            if (player == a1 && player == b2 && player == c3)
                returnValue = true;
            if (player == a3 && player == b2 && player == c1)
                returnValue = true;
            return returnValue;
        }
    }
}
