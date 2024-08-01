using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Integer or Double? "); string u = Console.ReadLine();
            if (u == "integer" || u == "Integer" || u == "INTEGER")
            {
                Console.Write("Enter a: "); int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: "); int b = int.Parse(Console.ReadLine());
                Console.Write("Enter c: "); int c = int.Parse(Console.ReadLine());
                Console.WriteLine("The addition of 2 numbers is: " + Calculator.Addition(a, b));
                Console.WriteLine("The subtraction of 2 numbers is: " + Calculator.Subtraction(a, b));
                Console.WriteLine("The multiplication of 2 numbers is: " + Calculator.Multiplication(a, b));
                Console.WriteLine("The division of 2 numbers is: " + Calculator.Division(a, b));
                Console.WriteLine("The maximum of 2 numbers is: " + Calculator.MaxInInt2(a, b));
                Console.WriteLine("The minimum of 2 numbers is: " + Calculator.MinInInt2(a, b));
                Console.WriteLine("The maximum of 3 numbers is: " + Calculator.MaxInInt3(a, b, c));
                Console.WriteLine("The minimum of 3 numbers is: " + Calculator.MinInInt3(a, b, c));
            }
            else if (u == "double" || u == "Double" || u == "DOUBLE")
            {
                Console.Write("Enter a: "); double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: "); double b = double.Parse(Console.ReadLine());
                Console.Write("Enter c: "); double c = double.Parse(Console.ReadLine());
                Console.WriteLine("The addition of 2 numbers is: " + Calculator.Addition(a, b));
                Console.WriteLine("The subtraction of 2 numbers is: " + Calculator.Subtraction(a, b));
                Console.WriteLine("The multiplication of 2 numbers is: " + Calculator.Multiplication(a, b));
                Console.WriteLine("The division of 2 numbers is: " + Calculator.Division(a, b));
                Console.WriteLine("The maximum of 2 numbers is: " + Calculator.MaxInDouble2(a, b));
                Console.WriteLine("The minimum of 2 numbers is: " + Calculator.MinInDouble2(a, b));
                Console.WriteLine("The maximum of 3 numbers is: " + Calculator.MaxInDouble3(a, b, c));
                Console.WriteLine("The minimum of 3 numbers is: " + Calculator.MinInDouble3(a, b, c));
            }
            Console.ReadLine();
        }
    }
}
