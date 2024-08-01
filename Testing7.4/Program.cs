using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing7._4
{
    class Bai6
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Nhap so dong m: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dong n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[n, m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[j, i] = a[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
