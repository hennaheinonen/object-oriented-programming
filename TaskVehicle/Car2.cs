using System;
namespace TaskVehicleInheritance
{
    public class Car2 : Vehicle
    {
        //Fields
        protected int size;
        protected string desing;
        protected int doorNumber;

        //Constructors
        public Car2() : base() 
        {
            size=0;
            desing="unknow";
            doorNumber=0;
        }

        public Car2(string type, string brand, int model, double price) : base(type,brand,model,price)
        {
            
        }

        public Car2(string type, string brand, int model, double price, int size, string desing, int doorNumber) : base (type, brand, model, price)
        {
            this.size = size;
            this.desing = desing;
            this.doorNumber = doorNumber;
        }

        //Method overriding 
        public override void ShowInfo()
        {
            Console.WriteLine($"Type : {type}\nBrand : {brand}\nModel : {model}\nPrice : {price:c}\nSize : {size}\nDesing : {desing}\nDoors number : {doorNumber}\n" +
                              "=============================================================");
                   
        }

        public override string ToString() 
        {
            return "The End";
        }
        public override bool Equals(object obj) 
        {
            if (this.type == ((Car2)obj).type)
                return true;
            else
                return false;
        }

    }
}
