using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing7._5
{
    class Bai7
    {
        static void Main(string[] args)
        {
            int m, n;           
            Console.Write("Nhap m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a, b = new int[m, n];
            Console.Write("Nhap ma tran a: ");
            a = NhapMang(m, n);
            Console.Write("Nhap ma tran b: ");
            b = NhapMang(m, n);
            XuatMang(a);
            XuatMang(b);
            Console.Write("Khoang cach giua 2 ma tran: " + Math.Round(EuclidSpace(a, b, m, n),2));
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
        public static double EuclidSpace(int[,] a, int[,] b, int m, int n)
        {
            double sum = 0;
            
            for (int i = 0; i < m; i++)
            {
                double d = Math.Sqrt(sum);
                for (int j = 0; j < n; j++)
                {                    
                    double tmp = (a[i, j] - b[i, j])* (a[i, j] - b[i, j]);
                    sum += tmp;                   
                }
            }
            return Math.Sqrt(sum);
        }







    }
}
