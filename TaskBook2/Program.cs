using System;
using Literatule;

namespace TaskBook2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book2 book1 = new Book2("Twilight", "Stephenie Meyer", "Little, Brown and Company", 20.50f, "fantasy");

            Console.WriteLine($"Category now: {Book2.Catergory}");

            Book2 book2 = new Book2("Fifty Shades of Grey", "E. L. James", "Vintage Books", 25.50f, "erotic romance");

            book1.SearchBook("Twilight");
            book2.SearchBook("Fifty Shades of Grey");
           
            Console.WriteLine($"Category now: {Book2.Catergory}");
            Book2.ChangeCatergory("romance");
            Console.WriteLine($"Category now: {Book2.Catergory}");

            Author kirjailija = new Author("Stephenie", "1.2.1999", book1);
            Console.WriteLine(kirjailija.PrintAuthorInformation());
        }
    }
}
