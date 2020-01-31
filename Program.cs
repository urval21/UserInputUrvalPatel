using System;

namespace UserInputUrvalPatel
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hi, This is Urval Patel ";
            Console.WriteLine(greeting);

            string nextGreeting = "Type Something...";
            Console.WriteLine(nextGreeting);

            nextGreeting = Console.ReadLine();

            Console.WriteLine("You Typed");

           

        }
    }
}
