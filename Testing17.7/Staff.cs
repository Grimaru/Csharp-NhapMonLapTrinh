using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._7
{
    class Staff : Person
    {
        //Attributes
        private string TheDepartment;
        private double TheSalary;

        //Constructors
        public Staff() : base()
        { }

        public Staff(string TheName, int TheBirthYear, string TheAddress, string TheDepartment, double TheSalary) : base(TheName, TheBirthYear, TheAddress)
        {
            this.TheDepartment = TheDepartment;
            this.TheSalary = TheSalary;
        }

        //Methods
        public double GetUpdatedSalary()
        {
            return TheSalary;
        }

        public void SetUpdatedSalary(double TheSalary)
        {
            if (TheSalary == 0 || TheSalary > 0)
            {
                this.TheSalary = TheSalary;
            }
            else
            {
                Console.WriteLine("This kind of salary doesn't exist.");
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Your job's department: ");
            TheDepartment = Console.ReadLine();
            Console.Write("Your salary is: ");
            TheSalary = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Sutdent[{base.toString()}, Department: {TheDepartment}, Salary: {TheSalary}]";
        }
    }
}
