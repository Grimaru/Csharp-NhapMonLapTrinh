using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing8
{
    class Bai1
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Nhap so dong m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Nhap cac phan tu mang: ");
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"a[{0},{1}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("In mang theo tung hang");
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Row{i}: ");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("In mang theo tung cot");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Col{j}: ");
                for (int i = 0; i < m; i++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
