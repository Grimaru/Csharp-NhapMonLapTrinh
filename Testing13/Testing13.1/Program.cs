using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s.Split(' ')[0]);
            int x = int.Parse(s.Split(' ')[1]);
            int[] a = new int[n];
            NhapMang(a);
            int left = 0;
            int right = a.Length - 1;
            int flag = LineArSearch(a, left, right, x);
            KiemTraPhanTu(flag);
            Console.ReadKey();
        }

        static void NhapMang(int[] a)
        {
            string s = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(s.Split(' ')[i]);
            }
        }
        static void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
        static int LineArSearch(int[] a, int left, int right, int x)
        {
            if (left <= right)
            {
                int mid = (left + right) / 2 ;
                if (a[mid] == x)
                {
                    return mid;
                }
                if (a[mid] > x)
                {
                    return LineArSearch(a, left, mid - 1, x);
                }
                else
                {
                    return LineArSearch(a, mid + 1, right, x);
                }
            }
            return -1;
        }

        static int KiemTraPhanTu(int flag)
        {
            if (flag != -1)
            {
                Console.WriteLine("Yes.");
            }
            else
            {
                Console.WriteLine("No.");
            }
            return flag;
        }


    }
}
