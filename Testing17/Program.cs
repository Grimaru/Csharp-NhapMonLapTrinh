using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your student ID: "); string a = Console.ReadLine();
            Console.Write("Your full name: "); string b = Console.ReadLine();
            Console.Write("Your birth year: "); int c = int.Parse(Console.ReadLine()); 
            Console.Write("You're a girl, aren't you? "); bool d = bool.Parse(Console.ReadLine());
            Console.Write("Your class code: "); string e = Console.ReadLine();

            Student sinhvien = new Student(a,b,c,d,e);      
            Console.WriteLine("-----Here's your student info----------");
            sinhvien.PrintStudentInfo();

            Console.Write("Your new birth year: "); int f = int.Parse(Console.ReadLine());
            sinhvien.SetBirthYear(f);
            Console.WriteLine("-----Here's your student info (again)----------");
            sinhvien.PrintStudentInfo();

            Console.ReadKey();

        }
    }
}
