using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing16._1
{
    class Program
    {
        static int n, k;
        static int[] x;
        static bool[] isUsed;

        static int GiaiThua(int n)
        {
            if (n == 0) return 1;
            else return n * GiaiThua(n - 1);
        }

        static int TinhChinhHopKhongLap(int n, int k)
        {
            int a = GiaiThua(n) / GiaiThua(n - k);
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
                for (int j = 1; j <= n; j++)
                {
                    if(isUsed[j] == false)
                    {
                        x[i] = j;
                        isUsed[j] = true;
                        Try(i + 1);
                        isUsed[j] = false;
                    }
                    
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
            isUsed = new bool[n + 1];
            for(int i = 0; i < isUsed.Length; i++)
            {
                isUsed[i] = false;
            }
            Console.WriteLine(TinhChinhHopKhongLap(n, k));
            Try(1);

        }
    }
}
