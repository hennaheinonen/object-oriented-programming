using System;
namespace TaskVehicleInheritance
{
    public class Truck : Car2
    {
        //Feilds
        public int loadWeight;
        public int usagePerKg;

        //Constructors
        public Truck() : base() 
        {
            
        loadWeight = 10000;
        usagePerKg = 3;

        }

        public Truck(string type, string brand, int model, int price, int loadWeight, int usagePerKg, int size, string desing, int doorNumber) : base (type, brand, model, price, size, desing, doorNumber)
        {
        this.loadWeight = loadWeight;
        this.usagePerKg = usagePerKg;
        }

		
        //Methods
        public void CountUsage() 
        {
            Console.WriteLine($"Usage is : {loadWeight*usagePerKg}");

        }
        public override void ShowInfo() 
        {
            Console.WriteLine($"Type : {type}\nBrand : {brand}\nModel : {model}\nPrice : {price:c}\nSize : {size}\nDesign : {desing}\nDoor number : {doorNumber}\n" +
                              $"Load weight : {loadWeight}\nUsage per kilogram : {usagePerKg}");
           

        }
	}
}
