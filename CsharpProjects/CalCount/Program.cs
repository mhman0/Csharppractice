using System;
using System.Collections.Generic;

// Define a class representing a food item with name and calories
class FoodItem
{
    public string Name { get; set; }
    public int Calories { get; set; }
}

// Define the main calorie counter class
class CalorieCounter
{
    // List to store food log entries
    private List<FoodItem> foodLog;

    // Constructor to initialize the food log list
    public CalorieCounter()
    {
        foodLog = new List<FoodItem>();
    }

    // Method to add a food item to the log
    public void AddFoodItem(string name, int calories)
    {
        // Create a new FoodItem object
        FoodItem foodItem = new FoodItem { Name = name, Calories = calories };

        // Add the food item to the log
        foodLog.Add(foodItem);

        // Print a message indicating the addition of the food item
        Console.WriteLine($"Added {name} ({calories} calories) to your log.");
    }

    // Method to calculate and return the total calories in the log
    public int GetTotalCalories()
    {
        int totalCalories = 0;

        // Iterate through each food item in the log and sum up the calories
        foreach (FoodItem foodItem in foodLog)
        {
            totalCalories += foodItem.Calories;
        }

        // Return the total calories
        return totalCalories;
    }

    // Method to display the entire food log
    public void ViewFoodLog()
    {
        // Print the header for the food log
        Console.WriteLine("Food Log:");

        // Iterate through each food item in the log and print its details
        foreach (FoodItem foodItem in foodLog)
        {
            Console.WriteLine($"{foodItem.Name}: {foodItem.Calories} calories");
        }

        // Print the total calories in the log
        Console.WriteLine($"Total Calories: {GetTotalCalories()}\n");
    }
}

// Main program class
class Program
{
    // Main method
    static void Main()
    {
        // Create an instance of the CalorieCounter class
        CalorieCounter calorieCounter = new CalorieCounter();

        // Infinite loop for the main menu
        while (true)
        {
            // Display the main menu options
            Console.WriteLine("Calorie Counter");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. View Food Log");
            Console.WriteLine("3. Exit");

            // Prompt the user for their choice
            Console.Write("Enter your choice (1-3): ");
            string choice = Console.ReadLine();

            // Switch statement to handle user choices
            switch (choice)
            {
                // Case 1: Add Food Item
                case "1":
                    Console.Write("Enter food name: ");
                    string foodName = Console.ReadLine();

                    Console.Write("Enter calories: ");
                    if (int.TryParse(Console.ReadLine(), out int calories))
                    {
                        // Call the AddFoodItem method with user input
                        calorieCounter.AddFoodItem(foodName, calories);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Calories must be a valid number.");
                    }
                    break;

                // Case 2: View Food Log
                case "2":
                    // Call the ViewFoodLog method to display the food log
                    calorieCounter.ViewFoodLog();
                    break;

                // Case 3: Exit the program
                case "3":
                    Console.WriteLine("Exiting the calorie counter. Thank you for using this app");
                    return;

                // Default case: Handle invalid choices
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.\n");
                    break;
            }
        }
    }
}