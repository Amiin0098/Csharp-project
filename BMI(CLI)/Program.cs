using System;

namespace type
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "bmi")
            {
                HandleBMICommand(args);
            }
            else
            {
                Console.WriteLine("\nInvalid command :(");
                Console.WriteLine("Use --helps switch to show help\n");
            }

        }

        static void HandleBMICommand(string[] args)
        {
            if (args.Length == 2)
            {
                if (args[1] == "--version")
                {
                    DisplayVersion();
                    return;
                }
                else if (args[1] == "--helps")
                {
                    DisplayHelps();
                    return;
                }
            }

            if (args.Length == 5)
            {
                if (args[1] == "--weight" && args[3] == "--height")
                {
                    if (double.TryParse(args[2], out double weight) && double.TryParse(args[4], out double height))
                    {
                        if (weight == 0 && height == 0)
                        {
                            Console.WriteLine("Invalid input. Weight and height cannot both be zero.");
                            return;
                        }

                        if (weight == 0)
                        {
                            Console.WriteLine("Invalid weight. Weight must be a non-zero value.");
                            return;
                        }

                        if (height == 0)
                        {
                            Console.WriteLine("Invalid height. Height must be a non-zero value.");
                            return;
                        }

                        CalculateAndDisplayBMI(weight, height);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid weight or height. Please provide numeric values.");
                        return;
                    }
                }
                else if (args[1] == "--height" && args[3] == "--weight")
                {
                    if (double.TryParse(args[4], out double weight) && double.TryParse(args[2], out double height))
                    {
                        if (weight == 0 && height == 0)
                        {
                            Console.WriteLine("Invalid input. Weight and height cannot both be zero.");
                            return;
                        }

                        if (weight == 0)
                        {
                            Console.WriteLine("Invalid weight. Weight must be a non-zero value.");
                            return;
                        }

                        if (height == 0)
                        {
                            Console.WriteLine("Invalid height. Height must be a non-zero value.");
                            return;
                        }

                        CalculateAndDisplayBMI(weight, height);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid weight or height. Please provide numeric values.");
                        return;
                    }
                }
            }

            Console.WriteLine("\nInvalid command :(");
            Console.WriteLine("Use --helps switch to show help\n");
        }

        static void CalculateAndDisplayBMI(double weight, double height)
        {
            double bmi = CalculateBMI(weight, height);
            double roundedBMI = Math.Floor(bmi); // Round down the BMI value

            Console.WriteLine($"\nYour BMI is: {roundedBMI}");
            string status = GetBMIStatus(roundedBMI);
            Console.WriteLine($"Your Status is: {status}");
        }

        static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        static void DisplayHelps()
        {
            Console.WriteLine("Help information:\n");
            Console.WriteLine("Usage:\t");
            Console.WriteLine("--height\t Your height (centimeters)");
            Console.WriteLine("--weight\t Your weight (kilograms)");
            Console.WriteLine("--version\t Show current version");
            Console.WriteLine("--helps\t\t Show command list");
        }

        static void DisplayVersion()
        {
            Console.WriteLine("BMI Calculator - Version 1.0");
        }

        static string GetBMIStatus(double bmi)
        {
            if (bmi < 16)
            {
                return "Severe Thinness";
            }
            else if (bmi <= 17)
            {
                return "Moderate Thinness";
            }
            else if (bmi <= 18.5)
            {
                return "Mild Thinness";
            }
            else if (bmi <= 25)
            {
                return "Normal";
            }
            else if (bmi <= 30)
            {
                return "Overweight";
            }
            else if (bmi <= 35)
            {
                return "Obese Class I";
            }
            else if (bmi <= 40)
            {
                return "Obese Class II";
            }
            else
            {
                return "Obese Class III";
            }
        }
    }
}