using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing12
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Day nhi phan cua {n} la: {DECtoBIN(n)} ");
            Console.ReadKey();
        }

        static int DECtoBIN (int n)
        {
            int a;
            if (n != 0)
            {
                a = (n % 2) + 10 * DECtoBIN(n/2);
                return a;
            }
            else
            {
                return 0;
            }
        }        
    }
}
