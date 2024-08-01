using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._7
{
    class Person
    {
        //Attributes
        protected string TheName;
        protected int TheBirthYear;
        protected string TheAddress;

        //Constructors
        public Person()
        { }

        public Person(string TheName, int TheBirthYear, string TheAddress)
        {
            this.TheName = TheName;
            this.TheBirthYear = TheBirthYear;
            this.TheAddress = TheAddress;
        }

        //Methods
        public virtual void Input()
        {
            Console.Write("Your full name: ");
            TheName = Console.ReadLine();
            Console.Write("Your birth year: ");
            TheBirthYear = int.Parse(Console.ReadLine());
            Console.Write("Your address: ");
            TheAddress = Console.ReadLine();
        }

        public int GetAge()
        {
            int TheCurrentYear = DateTime.Now.Year;
            return TheCurrentYear - TheBirthYear;
        }

        public virtual string toString()
        {
            return $"Person[Name: {TheName}, Birth year: {TheBirthYear}, Age: {GetAge()}, Address: {TheAddress}]";
        }
    }
}
