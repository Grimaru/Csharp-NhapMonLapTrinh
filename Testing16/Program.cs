using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing16
{
    class Program
    {
        static int n, k;
        static int[] x;

        static int TinhChinhHopLap(int n, int k)
        {
            if (k == 0) return 1;
            else if (k % 2 == 0) return TinhChinhHopLap(n, k / 2) * TinhChinhHopLap(n, k / 2);
            else return n * TinhChinhHopLap(n, (k - 1) / 2) * TinhChinhHopLap(n, (k - 1) / 2);
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
            Console.WriteLine(TinhChinhHopLap(n,k));
            Try(1);
            
        }
    }
}
