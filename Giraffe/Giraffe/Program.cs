using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Bleak House";
            book1.author = "Charles Dickens";
            book1.pages = 850;

            Book book2 = new Book();
            book2.title = "Martin Eden";
            book2.author = "Jack London";
            book2.pages = 150;

            Console.WriteLine(book1.title);

            Console.ReadLine();
        }

    }
}
