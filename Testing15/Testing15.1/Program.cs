using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            QuickSort(a, 0, n - 1);
            XuatMang(a);
            Console.ReadKey();
        }

        static void NhapMang(int[] a, int n)
        {          
  
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatMang(int[] a)
        {
            Console.Write("");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int p = Partitioning(a, left, right);
                QuickSort(a, left, p);
                QuickSort(a, p + 1, right);
            }
        }

        static int Partitioning(int[] a, int left, int right)
        {
            int chot = a[(left + right) / 2];
            int i = left - 1, j = right + 1;
            while (true)
            {
                do i++; while (a[i] < chot);

                do j--; while (a[j] > chot);

                if (i >= j)
                {
                    return j;
                }
                int temp = a[i]; a[i] = a[j]; a[j] = temp;
            }
        }
    }
}
