using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[5][];

            for(int r = 0; r<5; r++)
            {
                for (int c = 0; c < r + 1; c++)
                {
                    a[r][c] = c + 1;
                    Console.WriteLine(a[r][c]);
                }
                    
                
            }
        }
    }
}
