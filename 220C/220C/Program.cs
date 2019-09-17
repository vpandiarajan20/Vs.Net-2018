using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            for (int row = 0; row < a.Length; row++)
                a[row] = new int[row];
            for (int row = 0; row < a.Length; row++)
            {
                for (int col = 0; col < a[row].Length; col++)
                    a[row][col] = 0;
            }
            a[0][0] = 1;
            a[1][1] = 2;
            a[1][2] = 3;
            for (int i = 0; i < 5; i++)
                a[2][i] = i + 1;
            for (int row = 0; row < a.Length; row++)
                for (int col = 0; col < a[row].Length; col++)
                    a[row][col] = col + 1;
        }
        static int[][] Print2dArray(int n)
        {
            int[][] a = new int[n][];
            for (int row = 0; row < a.Length; row++)
                a[row] = new int[row];
            for (int row = 0; row < a.Length; row++)
            {
                for (int col = 0; col < a[row].Length; col++)
                    a[row][col] = 0;
            }
            return a;
        }
    }
}
