using System;

namespace TaskPerson
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Person personHenna = new Person();

            personHenna.Name = "Henna H";
            Console.WriteLine($"Henna ikä: {personHenna.GetAge()}");

            personHenna.GrowOld();
            Console.WriteLine($"Henna ikä: {personHenna.GetAge()}");
            personHenna.GrowOld(50);
            personHenna.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
        }
    }
}
