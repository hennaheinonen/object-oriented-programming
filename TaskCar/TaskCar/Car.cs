using System;
namespace TaskCar
{
    public class Car
    {
		//Fields 
		public string Brand;
		public int Speed;
		
        //Constructor
        public Car()
        {
            Brand = "unknow";
            Speed = 0;
        }
        public Car(string brand, int speed) 
        {
            Brand = brand;
            Speed = speed;
        }
        //Methods
        public void AskData() 
        {
            Console.WriteLine("Input car brand: ");
            string userInput = Console.ReadLine();
            Brand = userInput;

            Console.WriteLine("Input car speed: ");
            string userInput1 = Console.ReadLine();
            Speed = int.Parse(userInput1);
                           
        }
        public void ShowCarInfo() 
        {
            Console.WriteLine($"Car brand is: {Brand}\nCar speed is: {Speed}");
        }
        public void Accelerate(int number) 
        {
            Speed = Speed + number;
        }
        public void Brake(int number) 
        {
            Speed = (Speed * number) / 100;
        }

    }
}
