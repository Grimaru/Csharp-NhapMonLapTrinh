using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._3
{
    public class Square : Rectangle
    {
        //Attributes
        //Properties
        //Constructors
        public Square () : base()
        { }

        public Square(double Side) : base(Side, Side)
        {

        }

        public Square(string Color, Boolean Filled, double Side) : base(Side, Side, Color, Filled)
        {

        }
    }
}
