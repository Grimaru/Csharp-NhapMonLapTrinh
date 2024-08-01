using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, c, d;
            Console.Write("Nhap so dong m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dong n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.Write("Nhap so dong c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dong d: ");
            d = int.Parse(Console.ReadLine());
            int[,] b = new int[c, d];
      
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

            for (int i = 0; i < c; i++)
            {

                for (int j = 0; j < d; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
