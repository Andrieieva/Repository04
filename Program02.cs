using System;
class Program
{
    public static double FindMin(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("At least one parameter is required.");
        }
        double min = numbers[0];
        foreach (double num in numbers)
        {
            min = num < min ? num : min;
        }
        return min;
    }
    static void Main()
    {
        Console.WriteLine("Enter a series of numbers separated by spaces:");

        string? input = Console.ReadLine();

        if (input != null)
        {
            string[] inputArray = input.Split(' ');

            double[] numbers = new double[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (double.TryParse(inputArray[i], out double num))
                {
                    numbers[i] = num;
                }
                else
                {
                    Console.WriteLine($"Invalid input: {inputArray[i]} is not a valid number.");
                    return;
                }
            }

            double min = FindMin(numbers);

            Console.WriteLine($"The minimum value among the provided numbers is: {min}");
        }
    }
}