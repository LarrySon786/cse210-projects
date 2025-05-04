using System;
using System.Formats.Asn1;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        string answerString;
        int answer;
        int total;
        total = 0;
        int numberOfNumbers;
        numberOfNumbers = 0;
        float averageOfNumbers;
        averageOfNumbers = 0;
        float highestNumber;
        highestNumber = 0;

        Console.WriteLine("Type a number to add to your list. Type 0 when finished.");
        do
        {
            Console.WriteLine("Enter Number: ");
            answerString = Console.ReadLine();
            answer = int.Parse(answerString);
            if (answer != 0)
            {
                numbers.Add(answer);
            }

        } while (answer != 0);

        foreach (int number in numbers)
        {
            total = total + number;
            numberOfNumbers = numberOfNumbers + 1;
            averageOfNumbers = total / numberOfNumbers;

            if (number > highestNumber)
            {
                highestNumber = number;
            }
        }
        Console.WriteLine($"The sum is {total}; the average is {averageOfNumbers}; the largest number is {highestNumber}");
    }
}