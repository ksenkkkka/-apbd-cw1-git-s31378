using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();

        int number1 = int.Parse(input1);
        int number2 = int.Parse(input2);

        Console.WriteLine("Numbers received: " + number1 + " and " + number2);
    }
}