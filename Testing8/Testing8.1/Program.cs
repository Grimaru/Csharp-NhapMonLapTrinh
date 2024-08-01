using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing8._1
{
    class Bai2
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Nhap so dong m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dong n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(" ", a[i,j]);
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
        }
    }
}
