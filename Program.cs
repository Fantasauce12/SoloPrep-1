// See https://aka.ms/new-console-template for more information
using System;

namespace solo_prep_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string first = Console.ReadLine();

            Console.Write("What is your last name? ");
            string last = Console.ReadLine();

            Console.WriteLine($"Your name is {last.ToUpper()}, {first} {last}");
        }
    }
}