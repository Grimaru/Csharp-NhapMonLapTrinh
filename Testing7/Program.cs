using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing7
{
    class Bai4
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Nhap m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a, b, c = new int[m, n];
            Console.Write("Nhap ma tran a: ");
            a = NhapMang(m, n);
            Console.Write("Nhap ma tran b: ");
            b = NhapMang(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
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
                  
        public static int[,] NhapMang(int m, int n)
        {
        int[,] arr = new int[m, n];
           for (int i = 0; i < m; i++)
           {
               for (int j = 0; j < n; j++)
               {
                  Console.WriteLine($"Nhap phan tu [{i},{j}]: ");
                  arr[i, j] = int.Parse(Console.ReadLine());
               }
           }
           return arr;
        }
    }
}

