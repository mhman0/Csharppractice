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
        quiz.AddFlashcard("What is the capital of France?", "Paris");
        quiz.AddFlashcard("What is the largest planet in our solar system?", "Jupiter");
        quiz.AddFlashcard("What is the powerhouse of the cell?", "Mitochondria");

        // Start the quiz
        quiz.StartQuiz();
    }
}
