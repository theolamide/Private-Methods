using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your First Name?");
            string firstName = Console.ReadLine();

            Console.Write("What is your Last Name?");
            string lastName = Console.ReadLine();

            Console.Write("What City are you from?");
            string city = Console.ReadLine();


            Console.WriteLine("Results");
            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);

            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));

            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return String.Concat(messageArray);
        }

        /*foreach (char item in messageArray)
            {
                Console.Write(item);
            }
        Console.Write(" ");
        */
    }
}
