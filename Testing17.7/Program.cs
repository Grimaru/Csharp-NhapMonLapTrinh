using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ThePerson = new Person();
            ThePerson.Input();
            Console.WriteLine(ThePerson.toString());

            Console.Write("You're a student or a staff? "); string a = Console.ReadLine();
            if (a == "student" || a == "Student")
            {
                Student TheStudent = new Student();
                TheStudent.Input();
                Console.WriteLine("Here's your info:");
                Console.WriteLine(TheStudent.ToString());
                Console.Write("Enter the new program: "); string b = Console.ReadLine();
                TheStudent.SetChangedProgram(b);
                Console.WriteLine("Here's your info:");
                Console.WriteLine(TheStudent.ToString());
            }
            else if (a == "staff" || a == "Staff")
            {
                Staff TheStaff = new Staff();
                TheStaff.Input();
                Console.WriteLine("Here's your info:");
                Console.WriteLine(TheStaff.ToString());
                Console.Write("Enter the new salary: "); double c = double.Parse(Console.ReadLine());
                TheStaff.SetUpdatedSalary(c);
                Console.WriteLine("Here's your info:");
                Console.WriteLine(TheStaff.ToString());
            }

            Console.ReadKey();
        }
    }
}
