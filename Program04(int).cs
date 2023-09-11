using System;
class Program
{
    public static bool TrySumIfOdd(int num1, int num2, out int sum)
    {
        sum = num1 + num2;
        return sum % 2 != 0;
    }

    static void Main()
    {
        Console.WriteLine("Enter two integers to check if their sum is odd or even.");
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool isSumOdd = TrySumIfOdd(num1, num2, out int sum);

        Console.WriteLine($"Is the sum of {num1} and {num2} odd? {isSumOdd}");
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
    }
}