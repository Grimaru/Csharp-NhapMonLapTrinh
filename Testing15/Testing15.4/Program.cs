using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing15._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            CountElements(a, n);
            Console.WriteLine("So phan tu khac nhau la: " + CountElements(a,n));
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

        static int CountElements(int[] a, int n)
        {

            int i, j;

            int count = 1;

            int flag = 2;

            for (i = 1; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                    {
                        flag = 0;
                        break;
                    }
                    else
                    flag = 1;
                }

                if (flag == 1)
                {
                    count++;
                }                 
            }
            return count;

        }
    }

}
