using System;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = GetNumbers();
            double maximum = FindMaximum(numbers);
            double minimum = FindMinimum(numbers);
            DisplayResult(minimum, maximum);
        }

        static double[] GetNumbers()
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = ReadPositiveInteger("Invalid input. Enter a positive integer: ");
            double[] numbers = new double[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                numbers[i] = ReadDoubleNumber("Invalid input. Enter a valid number: ");
            }

            return numbers;
        }
        static int ReadPositiveInteger(string errorMessage)
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine(errorMessage);
            }
            return value;
        }
        static double ReadDoubleNumber(string errorMessage)
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(errorMessage);
            }
            return value;
        }

        static double FindMinimum(double[] numbers)
        {
            double min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                min = Math.Min(min, numbers[i]);
            }

            return min;
        }

        static double FindMaximum(double[] numbers)
        {
            double max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                max = Math.Max(max, numbers[i]);
            }

            return max;
        }

        static void DisplayResult(double min, double max)
        {
            Console.WriteLine($"Minimum number: {min}");
            Console.WriteLine($"Maximum number: {max}");
        }
    }
}
