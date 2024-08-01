using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fraction or Mixed Fraction? "); string u = Console.ReadLine();
            if (u == "Fraction" || u == "fraction" || u == "FRACTION")
            {
                //Enter 2 fractions
                Console.WriteLine("-------------Enter the 1st fraction----------------");
                Console.Write("Enter numberator: "); int a = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator: "); int b = int.Parse(Console.ReadLine());
                Fraction the1stfraction = new Fraction(a, b);
                the1stfraction.SimplifyTheFraction();
                Console.WriteLine("The opposite value of the 1st fraction is: " + -the1stfraction);
                Console.WriteLine("The decimal is: " + the1stfraction.ToDecimal(a, b));
                Console.WriteLine();

                Console.WriteLine("-------------Enter the 2nd fraction----------------");
                Console.Write("Enter numberator: "); int c = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator: "); int d = int.Parse(Console.ReadLine());
                Fraction the2ndfraction = new Fraction(c, d);
                the2ndfraction.SimplifyTheFraction();
                Console.WriteLine("The opposite value of the 2nd fraction is: " + -the2ndfraction);
                Console.WriteLine("The decimal is: " + the2ndfraction.ToDecimal(c, d));
                Console.WriteLine();

                //All calculations of 2 fractions
                Console.WriteLine("--------All the calculations of 2 fractions--------");
                //The addition of 2 fractions in overloading.
                Fraction TheAddition = the1stfraction + the2ndfraction;
                TheAddition.SimplifyTheFraction();
                Console.WriteLine($"{the1stfraction.ToString()} + {the2ndfraction.ToString()} = {TheAddition.ToString()}");

                //The subtraction of 2 fractions in overloading.
                Fraction TheSubtraction = the1stfraction - the2ndfraction;
                TheSubtraction.SimplifyTheFraction();
                Console.WriteLine($"{the1stfraction.ToString()} - {the2ndfraction.ToString()} = {TheSubtraction.ToString()}");

                //The multiplication of 2 fractions in overloading.
                Fraction TheMultiplication = the1stfraction * the2ndfraction;
                TheMultiplication.SimplifyTheFraction();
                Console.WriteLine($"{the1stfraction.ToString()} * {the2ndfraction.ToString()} = {TheMultiplication.ToString()}");

                //The devision of 2 fractions in overloading.
                Fraction TheDevision = the1stfraction / the2ndfraction;
                TheDevision.SimplifyTheFraction();
                Console.WriteLine($"{the1stfraction.ToString()} / {the2ndfraction.ToString()} = {TheDevision.ToString()}");
            }
            else if (u == "Mixed Fraction" || u == "mixed fraction" || u == "MIXED FRACTION")
            {
                //Enter 2 mixed fractions
                Console.WriteLine("-------------Enter the 1st mixed fraction----------------");
                Console.Write("Enter the whole part: "); int e = int.Parse(Console.ReadLine());
                Console.Write("Enter numberator: "); int f = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator: "); int g = int.Parse(Console.ReadLine());
                MixedFraction the1stMixedFraction = new MixedFraction(e, f, g);
                the1stMixedFraction.SimplifyTheFraction();
                //Console.WriteLine("The opposite value of the 1st mixed fraction is: " + -the1stMixedFraction);
                Console.WriteLine("The fraction of the 1st mixed fraction is: " + the1stMixedFraction.toMixedFractionString());
                Console.WriteLine("The 1st mixed fraction is: " + the1stMixedFraction.toString());
                Console.WriteLine();

                Console.WriteLine("-------------Enter the 2nd mixed fraction----------------");
                Console.Write("Enter the whole part: "); int x = int.Parse(Console.ReadLine());
                Console.Write("Enter numberator: "); int y = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator: "); int z = int.Parse(Console.ReadLine());
                MixedFraction the2ndMixedFraction = new MixedFraction(x, y, z);
                the2ndMixedFraction.SimplifyTheFraction();
                //Console.WriteLine("The opposite value of the 2nd mixed fraction is: " + -the2ndMixedFraction);
                Console.WriteLine("The fraction of the 2nd mixed fraction is: " + the2ndMixedFraction.toMixedFractionString());
                Console.WriteLine("The 2nd mixed fraction is: " + the2ndMixedFraction.toString());
                Console.WriteLine();

                //All calculations of 2 mixed fractions
                Console.WriteLine("--------All the calculations of 2 mixed fractions--------");
                //The addition of 2 mixed fractions in overloading.
                MixedFraction TheMixedFractionAddition = the1stMixedFraction + the2ndMixedFraction;
                TheMixedFractionAddition.SimplifyTheFraction();
                Console.WriteLine($"{the1stMixedFraction.toString()} + {the2ndMixedFraction.toString()} = {TheMixedFractionAddition.toString()}");

                //The subtraction of 2 mixed fractions in overloading
                MixedFraction TheMixedFractionSubtraction = (MixedFraction)(the1stMixedFraction - the2ndMixedFraction);
                TheMixedFractionSubtraction.SimplifyTheFraction();
                Console.WriteLine($"{the1stMixedFraction.toString()} - {the2ndMixedFraction.toString()} = {TheMixedFractionSubtraction.toString()}");

                ////The multiplication of 2 mixed fractions in overloading. 
                Fraction TheMixedMultiplication = the1stMixedFraction * the2ndMixedFraction;
                TheMixedMultiplication.SimplifyTheFraction();
                Console.WriteLine($"{the1stMixedFraction.toString()} * {the2ndMixedFraction.toString()} = {TheMixedMultiplication.ToString()}");

                ////The devision of 2 mixed fractions in overloading.
                Fraction TheMixedDevision = the1stMixedFraction / the2ndMixedFraction;
                TheMixedDevision.SimplifyTheFraction();
                Console.WriteLine($"{the1stMixedFraction.toString()} / {the2ndMixedFraction.toString()} = {TheMixedDevision.ToString()}");
            }
            Console.ReadKey();
        }
    }
}
