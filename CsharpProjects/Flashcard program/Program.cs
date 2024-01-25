using System;
using System.Collections.Generic;

// Define a class representing a flashcard
class Flashcard
{
    // Properties for the question and answer
    public string Question { get; set; }
    public string Answer { get; set; }
}

// Define a class representing a flashcard quiz
class FlashcardQuiz
{
    // Private fields for the list of flashcards and the current card index
    private List<Flashcard> flashcards;
    private int currentCardIndex;

    // Constructor to initialize the flashcards list and current card index
    public FlashcardQuiz()
    {
        flashcards = new List<Flashcard>();
        currentCardIndex = 0;
    }

    // Method to add a new flashcard to the quiz
    public void AddFlashcard(string question, string answer)
    {
        flashcards.Add(new Flashcard { Question = question, Answer = answer });
    }

    // Method to start the flashcard quiz
    public void StartQuiz()
    {
        Console.WriteLine("=== Flashcard Quiz ===");
        Console.WriteLine("Type 'exit' to end the quiz.\n");

        // Loop through flashcards until the user decides to exit
        while (currentCardIndex < flashcards.Count)
        {
            DisplayCurrentFlashcard();  // Display the current flashcard
            string userAnswer = GetUserInput("Your answer: ");  // Get user's answer

            if (userAnswer.ToLower() == "exit")
                break;

            CheckAnswer(userAnswer);  // Check user's answer
        }

        Console.WriteLine("Quiz ended. Good job!");
    }

    // Method to display the current flashcard
    private void DisplayCurrentFlashcard()
    {
        Console.WriteLine($"Question: {flashcards[currentCardIndex].Question}");
    }

    // Method to check the user's answer against the correct answer
    private void CheckAnswer(string userAnswer)
    {
        if (userAnswer.ToLower() == flashcards[currentCardIndex].Answer.ToLower())
        {
            Console.WriteLine("Correct!\n");
        }
        else
        {
            Console.WriteLine($"Incorrect. The correct answer is: {flashcards[currentCardIndex].Answer}\n");
        }

        currentCardIndex++;
    }

    // Method to get user input with a given prompt
    private string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}

// Main program class
class Program
{
    // Main method
    static void Main()
    {
        FlashcardQuiz quiz = new FlashcardQuiz();  // Create an instance of FlashcardQuiz

        // Add flashcards to the quiz
        quiz.AddFlashcard("What is the definition of an object in OOP?", "Objects are the basic units of code used to create software applications in OOP languages...");
        quiz.AddFlashcard("What is the definition of classes in OOP?", "Classes are the parameters that help a program create objects...");
        quiz.AddFlashcard("What is an attribute defined as in OOP?", "Attributes are the characteristics of an object that define what it is...");

        // Start the quiz
        quiz.StartQuiz();
    }
}