using System;
namespace TaskProductInterFace
{
    public class Customer : ICustomer
    {
        public string customerName;
        public double customerShop;

        public Customer() 
        {
            customerName = "unknow";
            customerShop = 0;

        }
        public Customer(string customerName, double customerShop) 
        {
            this.customerName = customerName;
            this.customerShop = customerShop;
        }
        public void SearchCustomer() 
        {
            string newCustomerName = customerName;
            if (newCustomerName == customerName)
                Console.WriteLine($"{customerName}");
            else
                Console.WriteLine($"{null}");
        }
        public void CountBonus() 
        {
            if (customerShop <= 1000)
                Console.WriteLine($"2% Bonus : {customerShop * 0.02:c}\n");
            else if (customerShop > 1000 || customerShop < 2000)
                Console.WriteLine($"3% Bonus : {customerShop * 0.03:c}\n");
            else
                Console.WriteLine($"5% Bonus : {customerShop * 0.05:c}\n");
        }
    }
}
