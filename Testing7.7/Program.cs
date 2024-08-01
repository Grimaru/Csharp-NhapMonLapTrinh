using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing7._7
{
    class Bai8
    {
        static void Main(string[] args)
        {
            int n;            
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());           
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            int[,] c = new int[n, n];
            Console.Write("Nhap ma tran a: ");
            a = NhapManga(n);
            Console.Write("Nhap ma tran b: ");
            b = NhapMangb(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
           
            Console.WriteLine("Dot product cua 2 ma tran: " + DotProduct(a,b,n));
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

        public static int[,] NhapManga(int n)
        {
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
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

        public static int[,] NhapMangb(int n)
        {
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
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

        public static int DotProduct(int[,] a, int[,] b, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int d = sum;
                for (int j = 0; j < n; j++)
                {
                    int tmp = (a[i,j]*b[i,j]);
                    sum += tmp;
                }
            }
            return sum;
        }
    }
}
