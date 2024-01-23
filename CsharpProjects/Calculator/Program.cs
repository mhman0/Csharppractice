using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                break;
            }

            if (IsChoiceValid(choice))
            {
                Console.Write("Enter the first number: ");
                double num1 = GetNumberFromUser();

                Console.Write("Enter the second number: ");
                double num2 = GetNumberFromUser();

                double result = PerformOperation(choice, num1, num2);

                Console.WriteLine($"Result: {result}\n");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.\n");
            }
        }
    }

    static bool IsChoiceValid(string choice)
    {
        return choice == "1" || choice == "2" || choice == "3" || choice == "4";
    }

    static double GetNumberFromUser()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                return num;
            }
            else
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
        }
    }

    static double PerformOperation(string choice, double num1, double num2)
    {
        switch (choice)
        {
            case "1":
                return num1 + num2;
            case "2":
                return num1 - num2;
            case "3":
                return num1 * num2;
            case "4":
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return double.NaN;
                }
            default:
                return double.NaN;
        }
    }
}
