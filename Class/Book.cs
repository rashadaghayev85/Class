using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Book
    {
        public string name;
        public string author;

        public Book()
        {
            Console.WriteLine("pb101");
        }
        public Book(string name)
        {

            Console.WriteLine("hacker");
        }
        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
    }
}
