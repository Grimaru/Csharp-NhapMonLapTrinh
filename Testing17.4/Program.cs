using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The author's name: "); string a = Console.ReadLine();
            Console.Write("The author's email: "); string b = Console.ReadLine();
            Console.Write("Is it a female or an male author? "); char c = char.Parse(Console.ReadLine());
            Author theAuthor = new Author(a, b, c);

            Console.Write("The book's name: "); string d = Console.ReadLine();
            Console.Write("The book's price: "); double e = double.Parse(Console.ReadLine());
            Console.Write("The book's quantity: "); int f = int.Parse(Console.ReadLine());
            Book theBook = new Book(d, e, theAuthor, f);
            Console.WriteLine("Here's the info: " + theBook.ToString());

            Console.ReadKey();

        }
    }
}
