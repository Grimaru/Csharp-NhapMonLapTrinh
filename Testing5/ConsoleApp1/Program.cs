using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Nhap so dong: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];

            //in ma tran
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap gia tri phan tu [{0},{1}]: ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Mang vua nhap ");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}