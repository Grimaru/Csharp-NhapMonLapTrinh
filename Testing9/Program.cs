using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing9
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Nhap so dong m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dong n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" ", a[i, j]);
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

            Console.WriteLine("Tong cac phan tu trong mang la: " + SumIn1Array(a, m, n));
            Console.WriteLine("Tong cac phan tu chan trong mang la: " + SumOfEvenNumbersIn1Array(a, m, n));
            Console.WriteLine("Tong cac phan tu le trong mang la: " + SumOfOddNumbersIn1Array(a, m, n));
            Console.WriteLine("Trung binh cong cac phan tu trong mang la: " + TrungBinhCongCuaArray(a, m, n));

            Console.ReadKey();
        }

        public static int SumIn1Array(int[,] a, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                int d = sum;
                for (int j = 0; j < n; j++)
                {
                    int tmp = (a[i, j]);
                    sum += tmp;
                }
            }
            return sum;
        }

        public static int SumOfEvenNumbersIn1Array(int[,] a, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {                   
                    int tmp = (a[i, j]);
                    if (a[i, j] % 2 == 0)
                    {
                        sum += tmp;
                    }                   
                }
            }
            return sum;
        }

        public static int SumOfOddNumbersIn1Array(int[,] a, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int tmp = (a[i, j]);
                    if (a[i, j] % 2 == 1)
                    {
                        sum += tmp;
                    }
                }
            }
            return sum;
        }

        public static double TrungBinhCongCuaArray(int [,] a, int m, int n)
        {
            double sum = 0;
            for (int i = 0; i < m; i++)
            {
                double d = sum;
                for (int j = 0; j < n; j++)
                {
                    double tmp = (a[i, j]);
                    sum += tmp;
                }
            }
            double tb = sum / (m*n);
            return sum/(m*n);

        }

    }
}
