using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing16._2
{
    class Program
    {
        static int n, k;
        static int[] x;

        static int GiaiThua(int n)
        {
            if (n == 0) return 1;
            else return n * GiaiThua(n - 1);
        }

        static int TinhToHop(int n, int k)
        {
            int a = GiaiThua(n) / (GiaiThua(n - k) * GiaiThua(k));
            return a;
        }

        static void Try(int i)
        {
            if (i > k)
            {
                XuatNghiem();
            }
            else
            {
                for (int j = x[i - 1] + 1; j <= n - k + i; j++)
                {
                   x[i] = j;
                   Try(i + 1);
                }
            }

        }

        static void XuatNghiem()
        {
            Console.Write("{");
            for (int i = 1; i < k; i++)
            {
                Console.Write(x[i] + ", ");
            }
            Console.WriteLine(x[k] + "}");
        }

        static void Main(string[] args)
        {
            string[] Numbers = Console.ReadLine().Split();
            n = int.Parse(Numbers[0]);
            k = int.Parse(Numbers[1]);
            x = new int[k + 1];
            Console.WriteLine(TinhToHop(n, k));
            Try(1);

        }
    }
}
