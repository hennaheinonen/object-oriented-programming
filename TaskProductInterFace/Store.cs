using System;
namespace TaskProductInterFace
{
    public class Store : Product, IProducts, ICustomers
    {
        
        public string storeName;
        public double storeSales;
        Product[] products = new Product[1];
        Customer[] customers = new Customer[1];

        public Store()
        {
            storeName = "unknow";
            storeSales = 0;
        }
        public Store(string storeName, double storeSales)
        {
            this.storeName = storeName;
            this.storeSales = storeSales;
        }
        public override string ToString()
        {
            return string.Format($"Store name : {storeName}\nStore sales : {storeSales}");
        }
        public void AddProduct(Product[] products)
        {
            this.products = products;
        }
        public void PrintProducts()
        {
            int amountOfAllProducts = 0;
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product : {products[i].name}\nUnit price : {products[i].price:c}\nAmount : {products[i].number}\n");

                amountOfAllProducts += products[i].number;
            }
            Console.WriteLine($"Amount of all products in store {amountOfAllProducts}\n");
            Console.WriteLine("===============");

        }
        public void CountTotalValueNew() 
        {
            Console.WriteLine($"Total amount : {price * number:c}\n");
        }
        public void AddCustomer(Customer[] customers) 
        {
            this.customers = customers;
        }
        public void PrintCustomers() 
        {
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine($"Customer name : {customers[i].customerName}\nCustomer shop : {customers[i].customerShop:c}\n");

            }
            Console.WriteLine($"Total amount of customers: {customers.Length}");
        }

    }
}
