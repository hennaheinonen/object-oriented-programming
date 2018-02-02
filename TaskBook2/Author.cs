using System;
using Literatule;

namespace TaskBook2
{
    public class Author
    {
        private string _authorname;
        private string _birthday;
        private Book2 _book;

		public string Authorname { get => _authorname; set => _authorname = value; }
        public string Birthdey { get => _birthday; set => _birthday = value; }

         
        //Constructors
        public Author() 
        {
            _authorname = "unknow";
            _birthday = "unknow";
            _book = new Book2();

        }
        public Author(string authorname, string birthday, Book2 book) 
        {
            _authorname = authorname;
            _birthday = birthday;
            _book = book;
        }
        //Methods
        public string PrintAuthorInformation() 
        {
            return $"=======================\n" +
                $"Authorname : {_authorname}\n" +
                $"Birthday : {_birthday}\n" +
                $"Book : {_book.ToString()}";
        }

    }
}
