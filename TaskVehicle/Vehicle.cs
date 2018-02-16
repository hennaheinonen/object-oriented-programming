using System;
namespace TaskVehicleInheritance
{
    public abstract class Vehicle
    {
		//Fields
		protected string type;
		protected string brand;
		protected int model;
        protected double price;

		//Constructors
		public Vehicle()
		{
			type = "unknow";
			brand = "unknow";
			model = 0;
			price = 0;
		}
        public Vehicle(string type, string brand, int model, double price)
		{
			this.type = type;
			this.brand = brand;
			this.model = model;
			this.price = price;
		}

        //Methods
        abstract public void ShowInfo();
        //{
        //   Console.WriteLine($"Type : {type}\nBrand : {brand}\nModel : {model}\nPrice : {price}");
        //}        


    }
}
