using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Result: " + BinarySearch(a, x));
            Console.ReadKey();
        }
        static int BinarySearch(int[] a, int x)
        {
            int left = 0;
            int right = a.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (a[mid] == x)
                {
                    return mid;
                }
                if (a[mid] > x)
                {
                    right = mid - 1;
                    return BinarySearch(a, x);
                }
                else
                {
                    left = mid + 1;
                    return BinarySearch(a, x);
                }
            }
            return -1;


        }
    }
}
