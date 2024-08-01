using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a,n);       
            int left = 0;
            int right = a.Length - 1;
            int TheLine = BinarySearch(a, left, right, x) + 1;
            Console.WriteLine("Result is line number: " + TheLine);
            Console.ReadKey();
        }
        static int BinarySearch(int[] a, int left, int right, int x)
        {           
            if (left <= right)
            {
                int mid = (left + right) / 2;
                if (a[mid] == x)
                {
                    return mid;
                }
                if (a[mid] > x)
                {
                    return BinarySearch(a, left, mid - 1, x);
                }
                else
                {
                    return BinarySearch(a, mid + 1, right, x);
                }
            }
            return -1;
        }
        static void NhapMang(int[] a, int n)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
