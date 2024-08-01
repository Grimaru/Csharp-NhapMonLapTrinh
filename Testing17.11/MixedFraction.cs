using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._11
{
    class MixedFraction : Fraction
    {
        //Attributes
        private int TheWholePart;

        //Constructors
        public MixedFraction() : base()
        { }

        public MixedFraction(int TheWholePart, int Numberator, int Demoninator) : base(Numberator, Demoninator)
        {
            this.TheWholePart = TheWholePart;
        }

        //Methods
        public string toMixedFractionString()
        {
            int MixedFractionNumberator = this.TheWholePart * this.Denominator + this.Numberator;
            int MixedFractionDemoninator = this.Denominator;
            Fraction MixedFractiontoFraction = new Fraction(MixedFractionNumberator, MixedFractionDemoninator);
            return MixedFractiontoFraction.ToString();
        }

        //All comparisons of 2 fractions (methods)
        //Some notes
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        //Incomplete stuffs (need help too :'>)
        public static bool operator == (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            the1stMixedFraction.toMixedFractionString();
            the2ndMixedFraction.toMixedFractionString();
            int the1stMixedFractionNumberator = the1stMixedFraction.Numberator * the2ndMixedFraction.Denominator;
            int the2ndMixedFractionNumberator = the2ndMixedFraction.Numberator * the1stMixedFraction.Denominator;
            return (the1stMixedFractionNumberator == the2ndMixedFractionNumberator);
        }

        public static bool operator != (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            the1stMixedFraction.toMixedFractionString();
            the2ndMixedFraction.toMixedFractionString();
            return !(the1stMixedFraction == the2ndMixedFraction);
        }

        public static bool operator < (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            the1stMixedFraction.toMixedFractionString();
            the2ndMixedFraction.toMixedFractionString();
            int the1stMixedFractionNumberator = the1stMixedFraction.Numberator * the2ndMixedFraction.Denominator;
            int the2ndMixedFractionNumberator = the2ndMixedFraction.Numberator * the1stMixedFraction.Denominator;
            return (the1stMixedFractionNumberator - the2ndMixedFractionNumberator < 0);
        }

        public static bool operator >= (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            the1stMixedFraction.toMixedFractionString();
            the2ndMixedFraction.toMixedFractionString();
            int the1stMixedFractionNumberator = the1stMixedFraction.Numberator * the2ndMixedFraction.Denominator;
            int the2ndMixedFractionNumberator = the2ndMixedFraction.Numberator * the1stMixedFraction.Denominator;
            return !(the1stMixedFractionNumberator - the2ndMixedFractionNumberator < 0);
        }

        public static bool operator > (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            the1stMixedFraction.toMixedFractionString();
            the2ndMixedFraction.toMixedFractionString();
            int the1stMixedFractionNumberator = the1stMixedFraction.Numberator * the2ndMixedFraction.Denominator;
            int the2ndMixedFractionNumberator = the2ndMixedFraction.Numberator * the1stMixedFraction.Denominator;
            return (the1stMixedFractionNumberator - the2ndMixedFractionNumberator > 0);
        }

        public static bool operator <= (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            the1stMixedFraction.toMixedFractionString();
            the2ndMixedFraction.toMixedFractionString();
            int the1stMixedFractionNumberator = the1stMixedFraction.Numberator * the2ndMixedFraction.Denominator;
            int the2ndMixedFractionNumberator = the2ndMixedFraction.Numberator * the1stMixedFraction.Denominator;
            return !(the1stMixedFractionNumberator - the2ndMixedFractionNumberator > 0);
        }
        //Incomplete stuffs (Need help :'>)
        //public static MixedFraction operator -(MixedFraction b)
        //{
        //    return new MixedFraction(TheWholePart: -b.TheWholePart, Numberator : b.Numberator, b.Denominator);
        //}

        //All calculations of 2 mixed fractions (methods)
        public static MixedFraction operator + (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            int MixedTheWholePart = the1stMixedFraction.TheWholePart + the2ndMixedFraction.TheWholePart;
            int MixedNumberator = (the1stMixedFraction.Numberator * the2ndMixedFraction.Denominator) + (the2ndMixedFraction.Numberator * the1stMixedFraction.Denominator);
            int MixedDenominator = the1stMixedFraction.Denominator * the2ndMixedFraction.Denominator;
            return new MixedFraction(MixedTheWholePart, MixedNumberator, MixedDenominator);
        }

        public static Fraction operator - (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            int MixedTheWholePart = the1stMixedFraction.TheWholePart - the2ndMixedFraction.TheWholePart;
            int MixedNumberator = (the1stMixedFraction.Numberator * the2ndMixedFraction.Denominator) - (the2ndMixedFraction.Numberator * the1stMixedFraction.Denominator);
            int MixedDenominator = the1stMixedFraction.Denominator * the2ndMixedFraction.Denominator;
            return new MixedFraction(MixedTheWholePart, MixedNumberator, MixedDenominator);
        }

        public static Fraction operator * (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            int the1stMixedFractionNumberator = the1stMixedFraction.TheWholePart * the1stMixedFraction.Denominator + the1stMixedFraction.Numberator;
            int the2ndMixedFractionNumberator = the2ndMixedFraction.TheWholePart * the2ndMixedFraction.Denominator + the2ndMixedFraction.Numberator;
            int TheWholePart = 0;
            int Numberator = the1stMixedFractionNumberator * the2ndMixedFractionNumberator;
            int Denominator = the1stMixedFraction.Denominator * the2ndMixedFraction.Denominator;
            return new MixedFraction(TheWholePart, Numberator, Denominator);
        }

        public static Fraction operator / (MixedFraction the1stMixedFraction, MixedFraction the2ndMixedFraction)
        {
            int the1stMixedFractionNumberator = the1stMixedFraction.TheWholePart * the1stMixedFraction.Denominator + the1stMixedFraction.Numberator;
            int the2ndMixedFractionNumberator = the2ndMixedFraction.TheWholePart * the2ndMixedFraction.Denominator + the2ndMixedFraction.Numberator;
            int TheWholePart = 0;
            int Numberator = the1stMixedFractionNumberator * the2ndMixedFraction.Denominator;
            int Denominator = the1stMixedFraction.Denominator * the2ndMixedFractionNumberator;
            return new MixedFraction(TheWholePart, Numberator, Denominator);
        }

        public virtual string toString()
        {
            return TheWholePart + "(" + ToString() + ")";
        }
    }
}
