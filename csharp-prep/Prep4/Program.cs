using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            int userNumber = -1;
            while (userNumber != 0) {
                Console.Write("Enter a number: ");
                
                userNumber = int.Parse(Console.ReadLine());
                
                numbers.Add(userNumber);
            }

            int sum = 0;
            foreach (int number in numbers) {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            
            int max = numbers[0];

            foreach (int number in numbers) {
                if (number > max) {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            int min = numbers[0];

            foreach (int number in numbers) {
                if (number >= 0) {
                    break;
                }
                else if (number > min) {
                    min = number;
                }
            }
            Console.WriteLine($"The smallest positive number is: {min}");

            Console.WriteLine("The sorted list is:");
            numbers.Sort();
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        }
    }
}
