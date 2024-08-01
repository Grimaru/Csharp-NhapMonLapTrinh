using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._3
{
    public abstract class Shape
    {
        //Attributes
        protected string Color;
        protected bool Filled;

        //Properties
        public string NewColor
        {
            get { return Color; }
            set
            {
                if (Color == "No color")
                {
                    Console.WriteLine("So it hasn't been filled yet.");
                }
                else
                {
                    Color = value;
                }
            }
        }

        public bool IsFilled()
        {
            return Filled;
        }

        public void setFilled(bool Filled)
        {
            this.Filled = Filled;
        }

        //Constructors
        public Shape()
        { }
        public Shape(string Color, bool Filled)
        {
            this.Color = Color;
            this.Filled = Filled;
        }

        //Methods
        public abstract string toString();
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
