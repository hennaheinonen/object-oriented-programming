using System;
namespace ClassBook
{
    public class Book
    {


        //Fields
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constructor
        public Book()
        {
            Title = "unknow";
            Author = "unknow";
            Id = 0;
            Price = 0;
        }

        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }

        //Methods
        public void PrintBookInfo()
        {
            Console.WriteLine($"Title: {Title}\n" +
                              $"Author: {Author}\n" +
                              $"Id: {Id}\n" +
                              $"Price: {Price}");
        }
        public string CompareBook(Book book)
        {
            if (book.Price < Price)

                return ($"{this.Title} is more expensive than {book.Title}");
            else

                return ($"{book.Title} is more expensive than {this.Title}");

        }

    }
}
