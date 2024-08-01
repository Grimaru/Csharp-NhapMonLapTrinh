using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._9
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
        public virtual string toString() 
        {
            return TheWholePart + "(" + ToString() + ")";
        }
    }
}
