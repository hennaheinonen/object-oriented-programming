using System;
namespace TaskPerson
{
    public class Person
    {
            //Fields
            public string Name;
        private int age;

        //Constructor 
        public Person()
        {
            Name = "unknown";
            age = 0;
        }

        public Person(string name, int age)
        {

            Name = name;
            this.age = age;

        }

        //Methods
        public void GrowOld()
        {
            this.age++;
        }

        public void GrowOld(int number)
        {
            this.age = this.age + number;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"Nimi: {Name}\n" +
                              $"Ikä: {this.age}\n" +
                              $"Aikuinen: {IsAdult()}");
        }

        public bool IsAdult()
        {
            //return this.age >= 18;

            if (this.age >= 18)
                return true;
            else
                return false;
        }

        public int GetAge()
        {
            return this.age;

        }
    }

}
