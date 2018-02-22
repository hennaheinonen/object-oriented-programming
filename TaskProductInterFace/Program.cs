using System;

namespace TaskProductInterFace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Product[] products = new Product[3];
            Product product0 = new Product("Pencil", 2.30, 10);
            Product product1 = new Product("Ballpoint pen" ,3, 20);
            Product product2 = new Product("Ruler", 0.80, 15);

            products[0] = product0;
            products[0].SearchProduct();
            products[0].CountTotalValue();

            products[1] = product1;
            products[1].SearchProduct();
            products[1].CountTotalValue();

            products[2] = product2;
            products[2].SearchProduct();
            products[2].CountTotalValue();

            Customer[] customers = new Customer[3];
            Customer customer0 = new Customer("Pena Korhonen", 900);
            Customer customer1 = new Customer("Jaska Jokunen", 1569.50);
            Customer customer2 = new Customer("Henna Heinonen", 2999.99);

            Console.WriteLine("================");

            customers[0] = customer0;
            customers[0].SearchCustomer();
            customers[0].CountBonus();

            customers[1] = customer1;
            customers[1].SearchCustomer();
            customers[1].CountBonus();

            customers[2] = customer2;
            customers[2].SearchCustomer();
            customers[2].CountBonus();

            Store store = new Store("Prisma", 200000);
            store.AddProduct(products);
            store.AddCustomer(customers);

            Console.WriteLine("===============");
            store.PrintProducts();
            store.PrintCustomers();

           

        }

    }
}
