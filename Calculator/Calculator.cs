using System;

namespace My_app
{
    class Calculator
    {
        private double Number1 { get; set; }
        private double Number2 { get; set; }
        private char Operand { get; set; }

        private void GetNumbers()
        {
            try
            {
                Console.Write("Enter number1: ");
                Number1 = GetInput();

                Console.Write("Enter number2: ");
                Number2 = GetInput();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }

        public void GetOper()
        {
            try
            {
                Console.WriteLine("Options:");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an Option: ");
                Operand = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid operator.");
            }
        }

        public void ShowResult()
        {
            try
            {
                switch (Operand)
                {
                    case '+':
                        Add();
                        break;
                    case '-':
                        Subtract();
                        break;
                    case '*':
                        Multiply();
                        break;
                    case '/':
                        Divide();
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public double Add()
        {
            var result = Number1 + Number2;
            Console.WriteLine($"Your result: {Number1} + {Number2} = {result}");
            return result;
        }

        public double Subtract()
        {
            var result = Number1 - Number2;
            Console.WriteLine($"Your result: {Number1} - {Number2} = {result}");
            return result;
        }

        public double Multiply()
        {
            var result = Number1 * Number2;
            Console.WriteLine($"Your result: {Number1} * {Number2} = {result}");
            return result;
        }

        public double Divide()
        {
            if (Number2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            var result = Number1 / Number2;
            Console.WriteLine($"Your result: {Number1} / {Number2} = {result}");
            return result;
        }

        public void Run()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine("Calculator program");
                Console.WriteLine("-------------\n");
                GetNumbers();
                GetOper();
                ShowResult();
            }
            while (PlayAgain());
            Console.WriteLine("Thank you for using the calculator!");

        }

        private bool PlayAgain()
        {
            Console.Write("Do you want to play again? (Y/N): ");
            var answer = Console.ReadLine().ToUpper();
            return answer == "Y";
        }
        private double GetInput()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
