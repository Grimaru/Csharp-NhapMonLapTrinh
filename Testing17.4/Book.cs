using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._4
{
    class Book
    {
        //Attributes
        private string BookName;
        private double BookPrice;
        private Author BookAuthor;
        private int BookQuantity = 0;

        //Properties
        public Book(String BookName, double BookPrice, Author BookAuthor)
        {
            this.BookName = BookName;
            this.BookPrice = BookPrice;
            this.BookAuthor = BookAuthor;
        }

        public Book(String BookName, double BookPrice, Author BookAuthor, int BookQuantity)
        {
            this.BookName = BookName;
            this.BookPrice = BookPrice;
            this.BookAuthor = BookAuthor;
            this.BookQuantity = BookQuantity;
        }

        public String getBookName()
        {
            return BookName;
        }

        public void setBookName(String BookName)
        {
            this.BookName = BookName;
        }

        public double getBookPrice()
        {
            return BookPrice;
        }

        public void setBookPrice(double BookPrice)
        {
            this.BookPrice = BookPrice;
        }

        public int getBookQuantity()
        {
            return BookQuantity;
        }

        public Author getBookAuthor()
        {
            return BookAuthor;
        }

        public void setBookAuthor(Author BookAuthor)
        {
            this.BookAuthor = BookAuthor;
        }

        public void setBookQuantity(int BookQuantity)
        {
            this.BookQuantity = BookQuantity;
        }

        //Methods
        public void Input()
        {

        }

        public override string ToString()
        {
            return "Book[" + "Name = " + BookName + "," + "Author = " + BookAuthor + "," + "Price = " + BookPrice + "," + "Quantity = " + BookQuantity + "]";
        }
    }
}
