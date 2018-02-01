using System;

namespace TaskTicketPrice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Ticket customer = new Ticket();

            customer.isStudent = YesNo("Are you a student? Y/N?");
            customer.isConscript = YesNo("Are you a conscript? Y/N?");
            customer.isMtk = YesNo("Are you a MTK member? Y/N?");

            Console.WriteLine("How old are you?");
            string userInput = Console.ReadLine();
            customer.Age = int.Parse(userInput);

            customer.GetPrice();
        }

        public static bool YesNo(string message) 
        {
            Console.WriteLine(message);
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
                return true;
            else
                return false;
        }
    }
}
