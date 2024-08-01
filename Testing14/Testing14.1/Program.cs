using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s.Split(' ')[0]);
            GiaiThua(n);
            Console.WriteLine(GiaiThua(n));
            Console.ReadKey();
        }

        static int GiaiThua(int n)
        {
            if (n == 0) return 1;
            else return n * GiaiThua(n - 1);
        }
    }
}
