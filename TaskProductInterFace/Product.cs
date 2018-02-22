using System;
namespace TaskProductInterFace
{
    public class Product : Customer, IProduct
    {
        
        public string name;
        public double price;
        public int number;

        public Product() 
        {
            name = "unknow";
            price = 0;
            number = 0;
        }
        public Product(string name, double price, int number) 
        {
            this.name = name;
            this.price = price;
            this.number = number;
        }
        public void SearchProduct() 
        {
            string newName = name;
            if (newName == name)
                Console.WriteLine($"{name}");
            else
                Console.WriteLine($"{null}");
        }
        public void CountTotalValue() 
        {
            Console.WriteLine($"Total amount : {price * number:c}\n");
        }
    }
}
