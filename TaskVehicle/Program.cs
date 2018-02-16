using System;

namespace TaskVehicleInheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Vehicle vehicle1 = new Car2("Passenger car", "Audi", 2016, 50000, 300, "a4", 5);
            vehicle1.ShowInfo();

            Car2 car1 = new Car2("Passenger car", "Ford", 2017, 20000, 3, "Focus", 5);
            car1.ShowInfo();
            Console.WriteLine("Are first car and second car same type (True/False) : "+vehicle1.Equals(car1)+"\n=============================================================");

           
            Truck lorry = new Truck("Lorry", "Sisu", 2010, 100000, 10000, 3, 1000, "Truck", 2);
            lorry.ShowInfo();
            lorry.CountUsage();
            Console.WriteLine("============================================================");
            Console.WriteLine("Are first car and third car same type (True/False) : " + vehicle1.Equals(lorry) + "\n=============================================================");
            Console.WriteLine(car1.ToString());
          

        }
    }
}
