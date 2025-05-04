using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int numberSquared = SquareNumber(number);
            DisplayResult(numberSquared, name);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            return number;
        }

        static int SquareNumber(int number)
        {
            number = number * number;
            return number;
        }

        static void DisplayResult(int number, string name)
        {
            Console.WriteLine($"The name: {name}. Squared number: {number}.");
        }
        Main();




    }
}