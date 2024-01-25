// Importing the System namespace, which contains fundamental types and 
// basic functionalities such as console input/output.
using System;

// Define a class named Calculator
class Calculator
{
    // The main entry point for the application
    static void Main()
    {
        // Infinite loop for the calculator menu
        while (true)
        {
            // Display the calculator menu options
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            // Prompt the user for their choice
            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            // Check if the user wants to exit (choice 5)
            if (choice == "5")
            {
                break;
            }

            // Check if the user's choice is valid (between 1 and 4)
            if (IsChoiceValid(choice))
            {
                // Prompt the user for the first and second numbers
                Console.Write("Enter the first number: ");
                double num1 = GetNumberFromUser();

                Console.Write("Enter the second number: ");
                double num2 = GetNumberFromUser();

                // Perform the selected operation and display the result
                double result = PerformOperation(choice, num1, num2);
                Console.WriteLine($"Result: {result}\n");
            }
            else
            {
                // Display an error message for an invalid choice
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.\n");
            }
        }
    }

    // Function to check if the user's choice is valid (between 1 and 4)
    static bool IsChoiceValid(string choice)
    {
        return choice == "1" || choice == "2" || choice == "3" || choice == "4";
    }

    // Function to get a valid number input from the user
    static double GetNumberFromUser()
    {
        while (true)
        {
            // Read a line of input from the user
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                // If parsing is successful, return the number
                return num;
            }
            else
            {
                // If parsing fails, display an error message and prompt again
                Console.Write("Invalid input. Please enter a valid number: ");
            }
        }
    }

    // Function to perform the selected operation based on the user's choice
    static double PerformOperation(string choice, double num1, double num2)
    {
        switch (choice)
        {
            case "1":
                // Addition
                return num1 + num2;
            case "2":
                // Subtraction
                return num1 - num2;
            case "3":
                // Multiplication
                return num1 * num2;
            case "4":
                // Division (check for division by zero)
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    // Display an error message for division by zero
                    Console.WriteLine("Error: Division by zero.");
                    return double.NaN; // Return NaN (Not a Number) for invalid result
                }
            default:
                // Return NaN for an invalid choice
                return double.NaN;
        }
    }
}
