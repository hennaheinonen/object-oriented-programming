using System;
namespace TaskTicketPrice
{
    public class Ticket
    {
        //Fields
        public int Age;
        public float Price;
        private bool _isStudent;
        private bool _isMtk;
        private bool _isConscript;
        private int _discount;


        public bool isStudent { get => _isStudent; set => _isStudent = value; }
        public bool isConscript { get => _isConscript; set => _isConscript = value; }
        public bool isMtk { get => _isMtk; set => _isMtk = value; }

        //Constructor

        public Ticket()
        {
            Age = 0;
            Price = 16;
            _discount = 0;

        }
        public Ticket(int age, int discount)
        {
            Age = age;
            Price = 16;
            _discount = discount;

        }
        //Methods 
        public void GetPrice()
        {
            //ikäalennus
            if (Age <= 7)
                _discount = 100;


            else if (Age >= 7 && Age <= 15)
                _discount = 50;


            else if (Age >= 65)
                _discount = 50;

            if (isConscript)
                _discount = 50;

            if (isStudent)
                _discount = 45;

            if (isMtk)
                _discount = 15;

            if (isMtk && isStudent)
                _discount = 60;
            Console.WriteLine($"Price = {Price} * {_discount}% = {Price *_discount/100:c2}");
        }
    }
}