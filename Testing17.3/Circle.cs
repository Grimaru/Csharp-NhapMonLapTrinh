using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._3
{
    public class Circle : Shape
    {
        //Attributes
        protected double Radius;

        //Properties
        public double NewRadius
        {
            get { return Radius; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Have you seen a negative number of width?");
                }
                else
                {
                    Radius = value;
                }
            }
        }

        //Constructors
        public Circle() : base()
        { }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public Circle(double Radius, string Color, bool Filled) : base(Color, Filled)
        {
            this.Radius = Radius;
        }

        //Methods
        public void Input()
        {

        }

        public override string toString()
        {
            return this.Radius + " - " + this.Color + " - " + this.Filled;
        }

        public override double GetPerimeter()
        {
            return this.Radius * 2 * Math.PI;
        }

        public override double GetArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}