using System;
namespace TaskEmployee
{
    public class Employee
    {
		//Fields
		public string Name;
        public int Id;
		public string Position;
        public int Salary;

		//Constructor

		public Employee()
		{
			Name = "unknow";
			Id = 0;
			Position = "unknow";
			Salary = 0;
		}
        public Employee(string name, int id, string position, int salary)
		{
			Name = name;
			Id = id;
			Position = position;
			Salary = salary;
		}
		//Methods
        public void CompareSalary(Employee worker)
		{
            if (Salary > worker.Salary)
                Console.WriteLine($"{Name} has {Salary-worker.Salary}€ bigger salary than {worker.Name}");
            else
                Console.WriteLine($"{worker.Name} has {worker.Salary-Salary}€ bigger salary than {Name}");

        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name = {Name}\nId = {Id}\nPosition = {Position}\nSalary = {Salary} €\n");
        }
            
    }
}
