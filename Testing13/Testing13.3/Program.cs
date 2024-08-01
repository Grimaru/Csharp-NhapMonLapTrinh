using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            bool flag = KiemTraSoNguyenTo(n);
            YesOrNo(flag);
            Console.ReadKey();
        }

        static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i*i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool YesOrNo(bool flag)
        {
            if (flag)
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
