using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();

        if (!int.TryParse(input1, out int number1) || !int.TryParse(input2, out int number2))
        {
            Console.WriteLine("Feature branch: invalid input");
            return;
        }

        int result = StatisticsHelper.Sum(number1, number2);

        Console.WriteLine("Sum = " + result);
    }
}