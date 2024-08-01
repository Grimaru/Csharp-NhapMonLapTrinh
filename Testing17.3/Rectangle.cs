using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._3
{
    public class Rectangle : Shape
    {
        //Attributes
        protected double Width;
        protected double Length;

        //Properties
        public double NewWidth
        {
            get { return Width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Have you seen a negative number of width?");
                }
                else
                {
                    Width = value;
                }
            }
        }

        public double NewLength
        {
            get { return Length; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Have you seen a negative number of length?");
                }
                else
                {
                    Length = value;
                }
            }
        }


        //Constructors
        public Rectangle() : base()
        { }
        public Rectangle(double Width, double Length)
        {
            this.Width = Width;
            this.Length = Length;
        }

        public Rectangle(double Width, double Length, string Color, bool Filled) : base(Color, Filled)
        {
            this.Width = Width;
            this.Length = Length;
        }

        //Methods
        public void Input()
        {

        }

        public override string toString()
        {
            return this.Width + " - " + this.Length + " - " + this.Color + " - " + this.Filled;
        }

        public override double GetPerimeter()
        {
            return (this.Width + this.Length) * 2;
        }

        public override double GetArea()
        {
            return this.Width * this.Length;
        }
    }
}
