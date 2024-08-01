using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Enter the 1st fraction----------------");
            Console.Write("Enter numberator: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: "); int b = int.Parse(Console.ReadLine());
            Fraction the1stfraction = new Fraction(a, b);
            Console.WriteLine("The decimal is: " + the1stfraction.ToDecimal(a, b));

            Console.WriteLine("-------------Enter the 2nd fraction----------------");
            Console.Write("Enter numberator: "); int c = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: "); int d = int.Parse(Console.ReadLine());
            Fraction the2ndfraction = new Fraction(c, d);
            Console.WriteLine("The decimal is: " + the2ndfraction.ToDecimal(c, d));


            the1stfraction.Addition(the2ndfraction);
            the1stfraction.Subtraction(the2ndfraction);
            the1stfraction.Multiplication(the2ndfraction);
            the1stfraction.Division(the2ndfraction);

            Console.WriteLine("-------------Enter the mixed fraction----------------");
            Console.Write("Enter the whole part: "); int e = int.Parse(Console.ReadLine());
            Console.Write("Enter numberator: "); int f = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: "); int g = int.Parse(Console.ReadLine());
            MixedFraction theMixedFraction = new MixedFraction(e, f, g);
            Console.WriteLine("The mixed fraction is: " + theMixedFraction.toString());
            Console.ReadKey();
        }
    }
}
