using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._3
{
    public abstract class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the color: "); string a = Console.ReadLine();
            Console.Write("Is it filled? "); bool b = bool.Parse(Console.ReadLine());
            Shape TheShape;
            Console.Write("What's the shape like? "); string c = Console.ReadLine();
            if (c == "Rectangle" || c == "RECTANGLE")
            {
                Console.Write("Enter width: "); double d = double.Parse(Console.ReadLine());
                Console.Write("Enter length: "); double e = double.Parse(Console.ReadLine());
                TheShape = new Rectangle(d,e,a,b);
                Console.WriteLine("The area is: " + TheShape.GetArea());
                Console.WriteLine("The perimeter is: " + TheShape.GetPerimeter());
                Console.WriteLine(TheShape.toString());
            }
            else if (c == "Square" || c == "SQUARE")
            {
                Console.Write("Enter side: "); double f = double.Parse(Console.ReadLine());
                TheShape = new Square(a,b,f);
                Console.WriteLine("The area is: " + TheShape.GetArea());
                Console.WriteLine("The perimeter is: " + TheShape.GetPerimeter());
                Console.WriteLine(TheShape.toString());
            }
            else if (c == "Circle" || c == "CIRCLE")
            {
                Console.WriteLine("Enter radius: "); double g = double.Parse(Console.ReadLine());
                TheShape = new Circle(g,a,b);
                Console.WriteLine("The area is: " + TheShape.GetArea());
                Console.WriteLine("The perimeter is: " + TheShape.GetPerimeter());
                Console.WriteLine(TheShape.toString());
            }
            Console.ReadKey();
        }
    }
}
