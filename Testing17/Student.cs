using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17
{
    class Student
    {
        //Attributes
        private string StudentID;
        private string Name;
        private int BirthYear;
        private bool Gender;
        private string stdClass;

        //Properties
        public string NewStudentID
        {
            get {return StudentID;}
            set { }
        }

        public string NewName
        {
            get {return Name;}
            set { }
        }

        public int NewBirthYear
        {
            get {return BirthYear;}
            set 
            {
                int CurrentYear = DateTime.Now.Year;
                if (value > 0 && value <= CurrentYear)
                {
                    BirthYear = value;
                }
                else
                {
                    Console.WriteLine("You've met someone born in a negative year, haven't you?");
                }
            }           
        }

        public bool NewGender
        {
            get { return Gender; }
            set { }
        }

        public string NewstdClass
        {
            get { return stdClass; }
            set { }
        }


        //Constructors
        public Student() 
        { }
        public Student (string StudentID, string Name, int BirthYear, bool Gender, string stdClass)
        {
            this.StudentID = StudentID;
            this.Name = Name;
            this.BirthYear = BirthYear;
            this.Gender = Gender;
            this.stdClass = stdClass;
        }

        //Methods
        public int GetBirthYear()
        {
            return BirthYear;
        }

        public void SetBirthYear(int BirthYear)
        {
            int CurrentYear = DateTime.Now.Year;
            if (BirthYear > 0 && BirthYear <= CurrentYear)
            { 
                this.BirthYear = BirthYear; 
            }
            else
            {
                Console.WriteLine("You've met someone born in a negative year, haven't you?");
            }
        }

        public int GetYourAge(int BirthYear)
        {
            int YourAge = 0;
            int CurrentYear = DateTime.Now.Year;
            if (BirthYear > 0 && BirthYear < CurrentYear)
            {
                YourAge = CurrentYear - BirthYear;
            }
            else
            {
                Console.WriteLine("You've met someone born in a negative year, haven't you?");
            }
            return YourAge;
        }

       
        public void Input()
        {

        }
        public void PrintStudentInfo()
        {
            Console.WriteLine($"- Student ID: {StudentID}");
            Console.WriteLine($"- Full name: {Name}");
            Console.WriteLine($"- Birth year: {BirthYear}");
            Console.WriteLine($"- Current age: {GetYourAge(BirthYear)}");
            if (Gender == false)
            {
                Console.WriteLine("- Gender: Male");
            }
            else
            {
                Console.WriteLine("- Gender: Female");
            }
            Console.WriteLine($"- Class code: {stdClass}");
        }
    }
}
