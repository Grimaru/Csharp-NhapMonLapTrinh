using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing10._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //int m = int.Parse(s.Split(' ')[0]);
            Console.WriteLine(" ");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            int[,] a = new int[n, n];
            NhapMang(a, n);
            Console.WriteLine();
            PrintDuongCheoPhu(a, m, n);
            Console.ReadKey();
        }

        static void NhapMang(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s.Split(' ')[j]);
                }
            }
        }
        static void XuatMang(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintDuongCheoPhu(int[,] a, int m, int n)
        {
            for (int i = 0; i < n; i++)
            {
                m = m - 1;
                for (int j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        Console.Write(" " + a[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
