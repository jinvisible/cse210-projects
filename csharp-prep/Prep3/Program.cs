using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            bool a = true;

            while (a) {
                int ranNum = randomGenerator.Next(1, 100);

                int guess = -1;
                int count = 0;

                while (guess != ranNum) {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    count++;

                    if (ranNum > guess) {
                        Console.WriteLine("Higher");
                    }
                    else if (ranNum < guess) {
                        Console.WriteLine("Lower");
                    }
                    else {
                        Console.WriteLine("You guessed it!");
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"It took you {count} guesses.");
                Console.Write("Would you like to play again (yes/no)? ");
                string yn = Console.ReadLine();
                Console.WriteLine();

                if (yn == "no"){
                    a = false;
                }
            }

            Console.WriteLine("Thank you for playing. Goodbye.");
        }
    }
}
