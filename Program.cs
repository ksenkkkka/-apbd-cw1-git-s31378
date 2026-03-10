using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error: input cannot be empty");
            return;
        }

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Error: please enter a valid number");
            return;
        }

        Console.WriteLine("You entered: " + number);
    }
}