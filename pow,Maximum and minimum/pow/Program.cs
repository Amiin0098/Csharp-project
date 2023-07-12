using System;

namespace pow
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = GetNumber();
            double powerValue = GetPowerValue();
            double result = CalculatePower(number, powerValue);
            DisplayResult(result);

        }
        static double GetNumber()
        {
            Console.WriteLine("Enter number: ");
            double number = ValidateInput("Invalid input. Please enter a valid number:");
            return number;

        }

        static double GetPowerValue()
        {
            Console.WriteLine("Enter Power: ");
            double powerValue = ValidateInput("Invalid input. Please enter a valid number:");
            return powerValue;
        }
        static double ValidateInput(string errorMessage)
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(errorMessage);

            }
            return value;
        }
        static double CalculatePower(double number, double powerValue)
        {
            double result = Math.Pow(number, powerValue);
            return result;
        }
        static void DisplayResult(double result)
        {
            Console.WriteLine($"your result is: {result}\n");
        }
    }
}
