using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Problems
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static int SumArray(int[] a)
        {
            int rv = 0;
            for (int row = 0; row < a.Length; row++)
                rv = a[row] + rv;
            return rv;
        }
        static int SumArray2d(int[][] a)
        {
            int rv = 0;
            for (int row = 0; row < a.Length; row++)
                for (int col = 0; col < a[row].Length; col++)
                    rv = a[row][col] + rv;
            return rv;
        }
        static int MinArray(int[] a)
        {
            int rv = a[0];
            for (int row = 0; row < a.Length; row++)
                if (rv > a[row])
                    rv = a[row];
            return rv;     
        }
        static int MinArray2d(int[][] a)
        {
            int rv = a[0][0];
            for (int row = 0; row < a.Length; row++)
                for (int col = 0; col < a[row].Length; col++)
                    if (rv > a[row][col])
                        rv = a[row][col];
            return rv;
        }
        static int MaxArray(int[] a)
        {
            int rv = a[0];
            for (int row = 0; row < a.Length; row++)
                if (rv < a[row])
                    rv = a[row];
            return rv;   
        }
        static int MaxArray2d(int[][] a)
        {
            int rv = a[0][0];
            for (int row = 0; row < a.Length; row++)
                for (int col = 0; col < a[row].Length; col++)
                    if (rv < a[row][col])
                        rv = a[row][col];
            return rv;
        }
        static double StandardDev(int[] a)
        {
            int mean = 0;
            for (int row = 0; row < a.Length; row++)
                  mean = mean + a[row];
            mean = mean/a.Length;
            int sqdiff = 0;
            for (int row = 0; row < a.Length; row++)
                sqdiff = (a[row] - mean) * (a[row] - mean) + sqdiff;
            sqdiff = sqdiff / a.Length;
            return Math.Sqrt(sqdiff);
        }
        static int[] StandardDev2d(int[][] a)
        {
            int[] b = new int [a[row].Length];
            for (int row = 0; row < a.Length; row++)
                StandardDev(a[row]);
            mean = mean / a.Length;
            int sqdiff = 0;
            for (int row = 0; row < a.Length; row++)
                for (int col = 0; col < a[row].Length; col++)
                    sqdiff = (a[row][col] - mean) * (a[row][col] - mean) + sqdiff;
            sqdiff = sqdiff / a.Length;
            return Math.Sqrt(sqdiff);
        }

    }
}
