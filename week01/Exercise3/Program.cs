using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        string guessString;
        int guess;

        do
        {
            Console.WriteLine("Guess a number 1 - 11 and see if it is the magic number. ");
            guessString = Console.ReadLine();
            guess = int.Parse(guessString);
            if (guess == number)
            {
                Console.WriteLine($"Congragulations! The number was {number}.");
            }
            else if (guess < number)
            {Console.WriteLine("Higher!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Error");
            }
        } while (guess != number);


    }
}