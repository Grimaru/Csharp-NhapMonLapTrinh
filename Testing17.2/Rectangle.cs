using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._2
{
    class Rectangle
    {
        //Attributes
        private double Width;
        private double Height;

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

        public double NewHeight
        {
            get { return Height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Have you seen a negative number of height?");
                }
                else
                {
                    Height = value;
                }
            }
        }


        //Constructors
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        //Methods
        public void Input()
        {

        }

        public override string ToString()
        {
            return Width + " - " + Height;
        }

        public double GetPerimeter()
        {
            return (Width + Height) * 2;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public bool IsSameArea(Rectangle the2ndRectangle)
        {
            double the1stArea = this.GetArea();
            double the2ndArea = the2ndRectangle.GetArea();
            if (the1stArea == the2ndArea)
            {
                return true;
            }
            else return false;
        }
    }
}
