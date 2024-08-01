using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            NhapMang(out a);
            InterchangeSort(a);
            XuatMang(a);
            Console.ReadKey();
        }

        static void NhapMang(out int[] a)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
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

        static void InterchangeSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
}
