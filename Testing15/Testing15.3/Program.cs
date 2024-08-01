using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            XuatMang(a);
            bool[] arr = MarkedArray(a);
            for (int i = 1; i < a.Length; i++)
            {
                if (arr[i] == false)
                {
                    Console.WriteLine($"So tu nhien nho nhat khong xuat hien la: {i}");
                    break;
                }
            }
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

        static int FindMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        static bool[] MarkedArray(int[] a)
        {
            bool[] arr = new bool[FindMax(a) + 2];
            for (int i = 0; i < a.Length; i++)
            {
                arr[a[i]] = true;
            }
            return arr;
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

        

    }
}
