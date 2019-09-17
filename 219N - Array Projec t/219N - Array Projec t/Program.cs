using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219N___Array_Projec_t
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][]a= Fibseq(8);
            Console.Write(Array2dToString(a));
            Console.ReadLine();
        }
        static int[][] Fibseq(int n)
        {
            int[][]a = new int[n][];
            for (int i = 0; i < n; i++)
                a[i] = new int[i + 1];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    if (c <= 1)
                        a[r][c] = 1;
                    else
                        a[r][c] = a[r][c-1] + a[r][c-2];
                }
                    
            }
            return a;
        }
        static int[] IndividualSums(int[][] n)
        {
            int[] rv = new int[n.Length];
            int sum = 0;
            for (int r = 0; r < n.Length; r++)
            {
                sum = 0;
                for (int c = 0; c < n[r].Length; c++)
                    sum = sum + n[r][c + 1];
                rv[r] = sum;
            }
            return rv;
        }
        static string ArrayToString(int[] n)
        {
            string rv = "";
            for (int i = 0; i < n.Length; i++)
            {
                rv = rv + n[i] + " ";
            }
            rv = "{ " + rv + "}";
            return rv;
        }
        static string Array2dToString(int[][] n)
        {
            string rv = "";
            for (int i = 0; i < n.Length; i++)
            {
                rv = rv + ArrayToString(n[i]) + "\n  ";
            }
            return rv;
        }

    }
    
}
