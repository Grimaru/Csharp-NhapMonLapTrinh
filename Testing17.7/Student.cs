using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._7
{
    class Student : Person
    {
        //Attributes
        private string TheProgram;
        private int TheYear;

        //Constructors
        public Student() : base()
        { }

        public Student(string TheName, int TheBirthYear, string TheAddress, string TheProgram, int TheYear) : base(TheName, TheBirthYear, TheAddress)
        {
            this.TheProgram = TheProgram;
            this.TheYear = TheYear;
        }

        //Methods
        public string GetChangedProgram()
        {
            return TheProgram;
        }

        public void SetChangedProgram(string TheProgram)
        {
            this.TheProgram = TheProgram;
        }
        public override void Input() 
        {
            base.Input();
            Console.Write("Your program: ");
            TheProgram = Console.ReadLine();
            Console.Write("Studying in year: ");
            TheYear = int.Parse(Console.ReadLine());            
        }

        public override string ToString()
        {
            return $"Sutdent[{base.toString()}, Program: {TheProgram}, Year: {TheYear}]";
        }
    }
}
