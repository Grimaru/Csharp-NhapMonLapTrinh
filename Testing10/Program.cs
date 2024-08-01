using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing10
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
            PrintTheKthRow(a);
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

        static void PrintTheKthRow(int[,] a)
        {
            Console.Write("Nhap k: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                if (i == k - 1)
                {
                    Console.Write($"Row{i + 1}: ");
                }                
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == k - 1)
                    {
                        Console.Write($"{a[i, j]} ");
                    }                                                         
                }               
                
            }
        }
    }
}
