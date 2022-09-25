using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeL = null;
            Console.Write("What is your grade percent? ");
            string input = Console.ReadLine();
            int grade = int.Parse(input);

            if (grade >= 90) {
                gradeL = "A";
            }
            else if (grade >= 80) {
                gradeL = "B";
            }
            else if (grade >= 70) {
                gradeL = "C";
            }
            else if (grade >= 60) {
                gradeL = "D";
            }
            else {
                gradeL = "F";
            }

            string sign = null;
            int lastDigit = grade % (10);
            if (lastDigit >= 7) {
                sign = "+";
            }
            else if (lastDigit < 3) {
                sign = "-";
            }
            else {
                sign = "";
            }

            if (grade >= 93) {
                sign = "";
            }

            if (gradeL == "F") {
                sign = "";
            }

            Console.WriteLine($"Your letter grade is: {gradeL}{sign}");

            if (grade >= 70) {
                Console.WriteLine("Congratulations! You passed the class!");
            }
            else {
                Console.WriteLine("Stay focused and you'll get it next time!");
            }
        }
    }
}
