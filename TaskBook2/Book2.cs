using System;
namespace Literatule
{
    public class Book2
    {
        //Fields
        private string _name;
        private string _author;
        private string _publisher;
        private float _price;
        private static string _catergory;

        public string Name { get => _name; set => _name = value; }
        public string Author { get => _author; set => _author = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }

        public static string Catergory { get => _catergory; }


        //Constructors
        public Book2()
        {
            _name = "unknow";
            _author = "unknow";
            _publisher = "unknow";
            Price = 0;
            _catergory = "unknow";
        }
        public Book2(string name, string author, string publisher, float price, string catergory)
        {
            _name = name;
            _author = author;
            _publisher = publisher;
            Price = price;
            _catergory = catergory;
        }
        public void SearchBook(string name)
        {
            if (_name == name)

                Console.WriteLine($"Book was found!\nName : {_name}\nAuthor : {_author}\nPublisher : {_publisher}\nPrice : {_price:c2}\nCatergory : {_catergory}");
            else
                Console.WriteLine($"Book didnt find");
        }
        public static void ChangeCatergory(string catergory)
        {
            _catergory = catergory;
        }

        public override string ToString()
        {
            //return string.Format("[Book2: _name={0}, _author={1}, _publisher={2}, _price={3}, _catergory={4}]", _name, _author, _publisher, _price, _catergory);
            return $"Book: {Name}\n" +
                $"Author: {Author}\n" +
                $"Publisher: {Publisher}\n" +
                $"Price: {Price:c2}\n" +
                $"---------------------------\n";
        }

        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                if (value > 30)
                    _price = value * 0.90f;
            }
        }
    }
}
