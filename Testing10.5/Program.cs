using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing10._5
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
            TrungBinhTheoCol(a, m);
            TrungBinhTheoRow(a, n);


            Console.ReadKey();
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

        

        static double TrungBinhTheoCol(int[,] a, int m)
        {
            double sum = 0;
            double tb = 0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    sum += a[j, i];
                    tb = sum / m;
                }
                Console.WriteLine($"Trung binh theo cot {i}: " + tb);
            }
            return tb;

        }

        static double TrungBinhTheoRow(int[,] a, int n)
        {
            double sum = 0;
            double tb = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                    tb = sum / n;
                }

                Console.WriteLine($"Trung binh theo dong {i}: " + tb);
            }
            return tb;

        }
    }
}
