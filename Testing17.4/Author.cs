using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._4
{
    class Author
    {
        //Attributes
        private string AuthorName;
        private string AuthorEmail;
        private char AuthorGender;

        //Properties
        public String getAuthorName()
        {
            return AuthorName;
        }

        public void setAuthorName(String AuthorName)
        {
            this.AuthorName = AuthorName;
        }

        public String getAuthorEmail()
        {
            return AuthorEmail;
        }

        public void setAuthorEmail(String AuthorEmail)
        {
            this.AuthorEmail = AuthorEmail;
        }

        public Author()
        { }
        public Author(string AuthorName, string AuthorEmail, char AuthorGender)
        {
            this.AuthorName = AuthorName;
            this.AuthorEmail = AuthorEmail;
            this.AuthorGender = AuthorGender;
        }

        //Methods
        public void Input()
        {

        }

        public override string ToString()
        {
            return "Author[" + "Name = " + AuthorName + "," + "Email = " + AuthorEmail + "," + "Gender = " + AuthorGender + "]";
        }
    }
}
