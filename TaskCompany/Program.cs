using System;

namespace TaskCompany
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Company company1 = new Company();
            company1.Title = "Vaasan leipomo";
            company1.Address = "Katajanharjukatu 3";
            company1.Phone = "040509977294";
            company1.Outcome = 54004980;
            company1.Expense = 22000000;

            Company company2 = new Company(company1);
            Company c3 = new Company("Saimia", "Sinnarilankatu 36", "020202", 100000, 4000);


            company1.ShowInfo();
            company2.ShowInfo();
            company1.Profit();
            company2.Profit();
            c3.Profit();
        }
    }
}
