using System;
using System.Collections.Generic;

class Flashcard
{
    public string Question { get; set; }
    public string Answer { get; set; }
}

class FlashcardQuiz
{
    private List<Flashcard> flashcards;
    private int currentCardIndex;

    public FlashcardQuiz()
    {
        flashcards = new List<Flashcard>();
        currentCardIndex = 0;
    }

    public void AddFlashcard(string question, string answer)
    {
        flashcards.Add(new Flashcard { Question = question, Answer = answer });
    }

    public void StartQuiz()
    {
        Console.WriteLine("=== Flashcard Quiz ===");
        Console.WriteLine("Type 'exit' to end the quiz.\n");

        while (currentCardIndex < flashcards.Count)
        {
            DisplayCurrentFlashcard();
            string userAnswer = GetUserInput("Your answer: ");

            if (userAnswer.ToLower() == "exit")
                break;

            CheckAnswer(userAnswer);
        }

        Console.WriteLine("Quiz ended. Good job!");
    }

    private void DisplayCurrentFlashcard()
    {
        Console.WriteLine($"Question: {flashcards[currentCardIndex].Question}");
    }

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

    private string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}

class Program
{
    static void Main()
    {
        FlashcardQuiz quiz = new FlashcardQuiz();

        // Add flashcards
        quiz.AddFlashcard("What is the definition of an object in OOP?", "Objects are the basic units of code used to create software applications in OOP languages. All OOP languages use objects to build programs because they're easy to replicate and scale. An object can be any abstract data type that has specific characteristics and functions. For example, a specific user account in an online database is an object. This object has its own unique characteristics and can perform certain functions, like browsing or editing articles.");
        quiz.AddFlashcard("What is the definition of classes in OOP?", "Classes are the parameters that help a program create objects. While all OOP coding languages support objects, not all of them have classes. Many coding languages support both objects and classes. Each class has its own set of qualifications, and individual objects have unique data for each qualification.");
        quiz.AddFlashcard("What is an attribute defined as in OOP?", "Attributes are the characteristics of an object that define what it is. Classes determine which attributes an object has. For example, if we consider a class of humans, their attributes might include name, hair color and height. Individual humans, or objects, have unique entries for each attribute field.");

        // Start the quiz
        quiz.StartQuiz();
    }
}
