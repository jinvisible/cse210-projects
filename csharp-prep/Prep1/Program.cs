﻿using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is yout last name? ");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Your name is {firstName} {lastName}.");
            // Write your code here
        }
    }
}
