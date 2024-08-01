using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the month: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the year: "); int c = int.Parse(Console.ReadLine());
            Date theDate = new Date(a, b, c);
            Console.WriteLine(theDate.ToString());

            Console.ReadKey();
        }
    }

}

