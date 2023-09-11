using System;

class Program
{
    public static void FindMaxAndMin(double num1, double num2, double num3, out double max, out double min)
    {
        max = Math.Max(Math.Max(num1, num2), num3);
        min = Math.Min(Math.Min(num1, num2), num3);
    }

    public static void FindMaxAndMin(double num1, double num2, double num3, double num4, out double max, out double min)
    {
        max = Math.Max(Math.Max(Math.Max(num1, num2), num3), num4);
        min = Math.Min(Math.Min(Math.Min(num1, num2), num3), num4);
    }

    static void Main()
    {
        double a = 5.6;
        double b = 3.2;
        double c = 7.1;
        double d = 2.8;

        double max, min;

        // Call the overload with 3 parameters
        FindMaxAndMin(a, b, c, out max, out min);

        Console.WriteLine($"Among {a}, {b}, and {c}, Max = {max}, Min = {min}");

        // Call the overload with 4 parameters
        FindMaxAndMin(a, b, c, d, out max, out min);

        Console.WriteLine($"Among {a}, {b}, {c}, and {d}, Max = {max}, Min = {min}");
    }
}

