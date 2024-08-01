using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Enter the 1st fraction----------------");
            Console.Write("Enter numberator: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: "); int b = int.Parse(Console.ReadLine());
            Fraction the1stfraction = new Fraction(a, b);
            Console.WriteLine("The decimal is: " + the1stfraction.Decimal(a, b));

            Console.WriteLine("-------------Enter the 2nd fraction----------------");
            Console.Write("Enter numberator: "); int c = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: "); int d = int.Parse(Console.ReadLine());
            Fraction the2ndfraction = new Fraction(c, d);
            Console.WriteLine("The decimal is: " + the2ndfraction.Decimal(c, d));


            the1stfraction.Addition(the2ndfraction);            
            the1stfraction.Subtraction(the2ndfraction); 
            the1stfraction.Multiplication(the2ndfraction);
            the1stfraction.Division(the2ndfraction);

            Console.ReadKey();
        }
    }
}
