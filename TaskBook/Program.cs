using System;

namespace ClassBook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book bookHarryPotter = new Book();
            bookHarryPotter.Title = "Harry Potter";
            bookHarryPotter.Author = "J.K Rowling";
            bookHarryPotter.Id = 9854393;
            bookHarryPotter.Price = 29.95;

            Book bookTwilight = new Book();
            bookTwilight.Title = "Twilight";
            bookTwilight.Author = "Stephenie Meyer";
            bookTwilight.Id = 1068926;
            bookTwilight.Price = 25.50;

               bookHarryPotter.PrintBookInfo();
               bookTwilight.PrintBookInfo(); 

            Console.WriteLine($"{bookHarryPotter.CompareBook(bookTwilight)}");
           
        }
    }
}
