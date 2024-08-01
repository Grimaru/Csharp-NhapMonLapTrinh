using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lặt_vặt
{
    class Program
    {
        static bool KiemTraSoNguyen(double PhanDuoi)
        {
            if (PhanDuoi == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // Lặt vặt 1:
            Console.Write("Enter n: ");
            double n = double.Parse(Console.ReadLine());
            double PhanDuoi = n - (int)n;
            if (KiemTraSoNguyen(n))
            {
                Console.WriteLine($"{n} la so nguyen");
            }
            else
            {
                Console.WriteLine($"{n} khong la so nguyen");
            }
        }
    }
}
