using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing._1
{
    class Fraction
    {
        //Attributes
        protected int Numberator;
        protected int Denominator;

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

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numberator, a.Denominator);
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

        public double ToDecimal(int a, int b)
        {
            return (float)a / b;
        }

        public void SimplifyTheFraction()
        {
            int uocsochung = FindUocSoChungLonNhat(this.Numberator, this.Denominator);
            int Numberator = this.Numberator / uocsochung;
            int Denominator = this.Denominator / uocsochung;
            this.Numberator = Numberator;
            this.Denominator = Denominator;
            Fraction phansotoigian = new Fraction(Numberator, Denominator);
        }

        public static Fraction operator +(Fraction the1stfraction, Fraction the2ndfraction)
        {
            int Numberator = (the1stfraction.Numberator * the2ndfraction.Denominator) + (the2ndfraction.Numberator * the1stfraction.Denominator);
            int Denominator = the1stfraction.Denominator * the2ndfraction.Denominator;
            return new Fraction(Numberator, Denominator);
        }

        public static Fraction operator -(Fraction the1stfration, Fraction the2ndfraction)
        {
            int Numberator = (the1stfration.Numberator * the2ndfraction.Denominator) - (the2ndfraction.Numberator * the1stfration.Denominator);
            int Denominator = the1stfration.Denominator * the2ndfraction.Denominator;
            return new Fraction(Numberator, Denominator);
        }

        public static Fraction operator *(Fraction the1stfraction, Fraction the2ndfraction)
        {
            int Numberator = the1stfraction.Numberator * the2ndfraction.Numberator;
            int Denominator = the1stfraction.Denominator * the2ndfraction.Denominator;
            return new Fraction(Numberator, Denominator);
        }

        public static Fraction operator /(Fraction the1stfraction, Fraction the2ndfraction)
        {
            int Numberator = the1stfraction.Numberator * the2ndfraction.Denominator;
            int Denominator = the1stfraction.Denominator * the2ndfraction.Numberator;
            return new Fraction(Numberator, Denominator);
        }
    }
}
