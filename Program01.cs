using System;
class Program
{
    public static double FindMax(params double[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("At least one parameter is required.");
        }
        double max = numbers[0];
        foreach (double num in numbers)
        {
            max = num > max ? num : max;
        }
        return max;
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

            double max = FindMax(numbers);

            Console.WriteLine($"The maximum value among the provided numbers is: {max}");
        }
    }
}