using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int [n];
            NhapMang(a, n);
            CountingSort(a, n);
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

        static void CountingSort(int[] a, int n)
        {
            //100 ở đây (có thể nói) là số lớn nhất mà phần tử của mảng a có thể so sánh được? Chắc vậy :> (Sau này sẽ update lại vụ đó sau).
            int[] count = new int[100];
            for (int i = 1; i < 100; i++)
            {
                count[i] = 0;
            }

            for (int i = 1; i < n; i++)
            {
                count[a[i]]++;
            }

            int m = 0;
            for (int i = 1; i < 100; i++)
            {
                while (count[i] > 0)
                {
                    m++;
                    a[m] = i;
                    count[i]--;
                }
            }

        }

    }
}
