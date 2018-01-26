using System;

namespace TaskEmployee
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee[]employees = new Employee[3];
            employees[0] = new Employee("Henna", 12340, "Production Manager", 5000);
            employees[1] = new Employee("Amanda", 12341, "Marketing Manager", 5200);
            employees[2] = new Employee("Tia", 12342, "Staff Manager", 5500);

            employees[0].PrintEmployeeInfo();
            employees[1].PrintEmployeeInfo();
            employees[2].PrintEmployeeInfo();

            employees[0].CompareSalary(employees[1]);
            employees[0].CompareSalary(employees[2]);
        }
    }
}
