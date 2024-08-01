using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing7._2
{
    class Bai5
    {
        static void Main(string[] args)
        {
            int m, n, p;
            Console.Write("Nhap m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap p: ");
            p = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[n, p];
            int[,] c = new int[m, p];
            Console.Write("Nhap ma tran a: ");
            a = NhapManga(m, n);
            Console.Write("Nhap ma tran b: ");
            b = NhapMangb(n, p);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }


            XuatMang(c);
            Console.ReadKey();
        }

        public static void XuatMang(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] NhapManga(int m, int n)
        {
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine();
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        public static int[,] NhapMangb(int n, int p)
        {
            int[,] arr = new int[n, p];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.WriteLine();
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }
    }
}

