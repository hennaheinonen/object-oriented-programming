using System;
namespace TaskCompany
{
    public class Company
    {
        //Fields
        public string Title;
        public string Address;
        public string Phone;
        public int Outcome;
        public int Expense;

        //Constructor
        public Company()
        {
            Title = "unknow";
            Address = "unknow";
            Phone = "000";
            Outcome = 0;
            Expense = 0;
        }
        public Company(string title, string address, string phone, int outcome, int expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expense = expense;
        }
        //Copy constructor 
        public Company(Company previousCompany)
        {
            Title = previousCompany.Title;
            Address = previousCompany.Address;
            Phone = previousCompany.Phone;
            Outcome = previousCompany.Outcome;
            Expense = previousCompany.Expense;
        }
        //Methods
        public void ShowInfo()
        {
            Console.WriteLine($"Title = {Title}\nAddress = {Address}\nPhone = {Phone}\nOutcome = {Outcome}\nExpense = {Expense}");
        }
        public void Profit()
        {
			int profit = (Outcome - Expense) / Expense * 100;

			if (profit < 100)
			{
                Console.WriteLine($"{Title}: Profit {profit} is under 100% bigger than expense. Company is doing poorly.");
			}

			else if (profit >= 300)
			{
                Console.WriteLine($"{Title}: Profit {profit} is at least 300% bigger than expense. Company is doing fine.");
			}
			else
			{
                Console.WriteLine($"{Title}: Profit {profit} is at least 200% bigger than expense. Company is doing okay.");
			}
        }
    }
}
