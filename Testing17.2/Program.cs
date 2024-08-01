using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st rectangle");
            Console.Write("Enter the width: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: "); double b = double.Parse(Console.ReadLine());
            Rectangle TheRectangle = new Rectangle(a, b);
            
            Console.WriteLine("The infomation of the rectangle: " + TheRectangle.ToString());
            Console.WriteLine("The perimeter of the rectangle: " + TheRectangle.GetPerimeter());
            Console.WriteLine("The area of the rectangle: " + TheRectangle.GetArea());

            Console.WriteLine("Enter the 2nd rectangle");
            Console.Write("Enter the width: "); double c = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: "); double d = double.Parse(Console.ReadLine());
            Rectangle The2ndRectangle = new Rectangle(c, d);

            Console.WriteLine("The area of the 2nd rectangle: " + The2ndRectangle.GetArea());

            TheRectangle.IsSameArea(The2ndRectangle);
            if (TheRectangle.IsSameArea(The2ndRectangle) == true)
            {
                Console.WriteLine("Uh huh, they have the same area.");
            }
            else
            {
                Console.WriteLine("Nah. No, they don't.");
            }

            Console.ReadKey();
        }
    }
}
