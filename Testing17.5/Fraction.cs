using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._1
{
    class Fraction
    {
        //Attributes
        private int Numberator;
        private int Denominator;

        //Properties
        public int NewNumberator
        {
            get { return Numberator; }
            set { Numberator = value; }
        }

        public int NewDenominator
        {
            get { return Denominator; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("No fraction has denominator = 0!");
                }
                else
                {
                    Denominator = value;
                }
            }
        }

        //Constructors
        public Fraction()
        {
            Numberator = 0;
            Denominator = 1;
        }
        public Fraction(int Numberator, int Denominator)
        {
            this.Numberator = Numberator;
            this.Denominator = Denominator;
        }

        //Methods
        public void Input()
        {

        }

        public override string ToString()
        {
            return Numberator + "/" + Denominator;
        }

        public int FindUocSoChungLonNhat(int a, int b)
        {
            while (b != 0)
            {
                int r = b;
                b = a % b;
                a = r;
            }
            return a;
        }

        public double Decimal(int a, int b)
        {
            return (float)a / b;
        }

        public void SimlifyTheFraction()
        {
            int uocsochung = FindUocSoChungLonNhat(this.Numberator, this.Denominator);
            int Numberator = this.Numberator / uocsochung;
            int Denominator = this.Denominator / uocsochung;
            this.Numberator = Numberator;
            this.Denominator = Denominator;
            Fraction phansotoigian = new Fraction(Numberator, Denominator);
        }

        public static void Addition(Fraction the1stfraction, Fraction the2ndfraction)
        {
            int Numberator = (the1stfraction.Numberator * the2ndfraction.Denominator) + (the2ndfraction.Numberator * the1stfraction.Denominator);
            int Denominator = the1stfraction.Denominator * the2ndfraction.Denominator;
            Fraction AdditionOfFractions = new Fraction(Numberator, Denominator);
            AdditionOfFractions.SimlifyTheFraction();
            Console.WriteLine("Addition of these two fractions is: " + AdditionOfFractions.ToString());
        }

        public static void Subtraction(Fraction the1stfraction, Fraction the2ndfraction)
        {
            int Numberator = (the1stfraction.Numberator * the2ndfraction.Denominator) - (the2ndfraction.Numberator * the1stfraction.Denominator);
            int Denominator = the1stfraction.Denominator * the2ndfraction.Denominator;
            Fraction SubtractionOfFractions = new Fraction(Numberator, Denominator);
            SubtractionOfFractions.SimlifyTheFraction();
            Console.WriteLine("Subtraction of these two fractions is: " + SubtractionOfFractions.ToString());
        }

        public static void Multiplication(Fraction the1stfraction, Fraction the2ndfraction)
        {
            int Numberator = the1stfraction.Numberator * the2ndfraction.Numberator;
            int Denominator = the1stfraction.Denominator * the2ndfraction.Denominator;
            Fraction MultiplicationOfFractions = new Fraction(Numberator, Denominator);
            MultiplicationOfFractions.SimlifyTheFraction();
            Console.WriteLine("Multiplication of these two fractions is: " + MultiplicationOfFractions.ToString());
        }

        public static void Division(Fraction the1stfraction, Fraction the2ndfraction)
        {
            int Numberator = the1stfraction.Numberator * the2ndfraction.Denominator;
            int Denominator = the1stfraction.Denominator * the2ndfraction.Numberator;
            Fraction DivisionOfFractions = new Fraction(Numberator, Denominator);
            DivisionOfFractions.SimlifyTheFraction();
            Console.WriteLine("Division of these two fractions is: " + DivisionOfFractions.ToString());
        }

    }
}
