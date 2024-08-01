using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing10._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();           
            int m = int.Parse(s.Split(' ')[0]);
            int n = int.Parse(s.Split(' ')[1]);
            int[,] a = new int[m, n];
            NhapMang(a, m, n);           
            XuatMang(a, m, n);                                 
            Console.ReadKey();
        }

        static void NhapMang(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s.Split(' ')[i]);
                }
            }
        }
        static void XuatMang(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }


    }
}
