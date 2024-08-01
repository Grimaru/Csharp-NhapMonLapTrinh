using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Nhap m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            Console.Write("Nhap ma tran: ");
            a = NhapMang(m, n);        
            Console.Write("Ma tran chuyen vi la: ", b[m,n]);
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    b[i, j] = a[j, i];
                }
            }
            
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
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine();
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        public static void ChuyenVi(int[,] a, int m, int n)
        {
            int[,] b = new int[m, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    b[i, j] = a[j, i];
                }
            }
        }

        
    }
}

