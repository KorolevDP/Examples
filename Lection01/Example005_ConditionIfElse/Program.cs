using System;

namespace ConditionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter user name: ");
            string username = Console.ReadLine();

            if(username.ToLower() == "maria")
            {
                Console.WriteLine("Hey!! Masha here!!");
            }
            else
            {
                Console.Write($"Hi! {username}");
            }
        }
    }
}

