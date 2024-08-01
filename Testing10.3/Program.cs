using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int m = int.Parse(s.Split(' ')[0]);
            int n = int.Parse(s.Split(' ')[1]);
            int[,] a = new int[m, n];
            NhapMang(a);
            Console.Write(" " + TongDiemTheoCol(a, m));
            Console.Write(" " + TongDiemTheoRow(a, n));
        }

        static void NhapMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(s.Split(' ')[j]);
                }
            }
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static double TongDiemTheoCol(int[,] a, int m)
        {
            double sum = 0;
            double tb = 0;
            for(int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write($"Col{j}: " + tb);
                double d = sum;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    double tmp = a[i, j];
                    sum += tmp;
                }
                tb = sum / m;
            }
            return tb;

        }

        static double TongDiemTheoRow(int[,] a, int n)
        {
            double sum = 0;
            double tb = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"Col{i}: " + tb);
                double d = sum;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    double tmp = a[i, j];
                    sum += tmp;
                }
                tb = sum / n;
            }
            return tb;

        }

    }
}
