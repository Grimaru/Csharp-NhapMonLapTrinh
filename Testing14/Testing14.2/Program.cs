using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s.Split(' ')[0]);
            int n = int.Parse(s.Split(' ')[1]);
            Console.WriteLine(LuyThua(a,n));
            Console.ReadKey();
        }

        static int LuyThua(int a, int n)
        {
            if (n == 0) return 1;
            else if (n % 2 == 0) return LuyThua(a,n / 2) * LuyThua(a,n / 2);
            else return a * LuyThua(a,(n - 1) / 2) * LuyThua(a,(n - 1) / 2);
        }
    }
}
