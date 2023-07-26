using System;

namespace My_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("WELCOME");
                DisplayMenu();

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ConvertToAlphabet();
                        break;
                    case "2":
                        ConvertToDayOfWeek();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Goodbye :)");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            static void DisplayMenu()
            {
                Console.WriteLine("Enter a number to execute :");
                Console.WriteLine("1) Conver number to alphabet");
                Console.WriteLine("2) Convert number to day of week");
                Console.WriteLine("3) Exit");
                Console.Write("--> ");
            }
            static void ConvertToDayOfWeek()
            {
                Console.Clear();
                Console.WriteLine("Enter a number between 1 to 7 for days of the week:");
                var day = Console.ReadLine();

                switch (day)
                {
                    case "1":
                        Console.WriteLine("--> Today is Saturday :)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("--> Today is Sunday :)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("--> Today is Monday :)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("--> Today is Tuesday :)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("--> Today is Wednesday :)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Console.WriteLine("--> Today is Thursday :)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "7":
                        Console.WriteLine("--> Today is Friday :)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("You entered out of range!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }


            }
            static void ConvertToAlphabet()
            {
                Console.Clear();
                Console.WriteLine("Enter a number between 1 to 10:");
                var number = Console.ReadLine();

                switch (number)
                {
                    case "1":
                        Console.WriteLine("--> Result: One");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("--> Result: Two");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("--> Result: Three");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("--> Result: Four");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("--> Result: Five");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Console.WriteLine("--> Result: Six");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "7":
                        Console.WriteLine("--> Result: Seven");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "8":
                        Console.WriteLine("--> Result: Eight");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "9":
                        Console.WriteLine("--> Result: Nine");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "10":
                        Console.WriteLine("--> Result: Ten");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("You entered out of range!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }

            }
        }
    }
}