using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    // Constants for screen dimensions and characters
    static int screenWidth = 80;
    static int screenHeight = 24;
    static char playerChar = '^';
    static char asteroidChar = 'O';
    static char bulletChar = '|';

    // Initial player position
    static int playerX = screenWidth / 2;
    static int playerY = screenHeight - 1;

    // Lists to store positions of asteroids and bullets
    static List<int[]> asteroids = new List<int[]>();
    static List<int[]> bullets = new List<int[]>();

    // Random number generator
    static Random random = new Random();

    static void Main()
    {
        // Set console window dimensions
        Console.WindowWidth = screenWidth;
        Console.WindowHeight = screenHeight;

        // Hide the cursor for a cleaner display
        Console.CursorVisible = false;

        ConsoleKeyInfo keyInfo;

        // Game loop
        while (true)
        {
            // Check for user input
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);

                // Move player left
                if (keyInfo.Key == ConsoleKey.LeftArrow && playerX > 0)
                {
                    playerX--;
                }
                // Move player right
                else if (keyInfo.Key == ConsoleKey.RightArrow && playerX < screenWidth - 1)
                {
                    playerX++;
                }

                // Shoot bullet
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    bullets.Add(new int[] { playerX, playerY - 1 });
                }
            }

            // Spawn asteroids randomly
            if (random.Next(0, 100) < 10)
            {
                asteroids.Add(new int[] { random.Next(0, screenWidth), 0 });
            }

            // Update game state
            UpdateGame();

            // Render game
            RenderGame();

            // Pause to control game speed
            Thread.Sleep(50);

            // Clear the console for the next frame
            Console.Clear();
        }
    }

    // Update the game state (e.g., move bullets and asteroids, check for collisions)
    static void UpdateGame()
    {
        // Move bullets upward
        for (int i = 0; i < bullets.Count; i++)
        {
            bullets[i][1]--;

            // Remove bullets that have moved off-screen
            if (bullets[i][1] < 0)
            {
                bullets.RemoveAt(i);
                i--;
            }
        }

        // Move asteroids downward
        for (int i = 0; i < asteroids.Count; i++)
        {
            asteroids[i][1]++;

            // Remove asteroids that have moved off-screen
            if (asteroids[i][1] >= screenHeight)
            {
                asteroids.RemoveAt(i);
                i--;
            }
        }

        // Check for collisions (player-asteroid, bullet-asteroid)
        for (int i = 0; i < asteroids.Count; i++)
        {
            // Check player-asteroid collision
            if (asteroids[i][0] == playerX && asteroids[i][1] == playerY)
            {
                // Game over
                Console.Clear();
                Console.WriteLine("Game Over!");
                Environment.Exit(0);
            }

            // Check bullet-asteroid collision
            for (int j = 0; j < bullets.Count; j++)
            {
                if (asteroids[i][0] == bullets[j][0] && asteroids[i][1] == bullets[j][1])
                {
                    // Destroy asteroid
                    asteroids.RemoveAt(i);
                    bullets.RemoveAt(j);
                    i--;
                    break;
                }
            }
        }
    }

    // Render the game on the console
    static void RenderGame()
    {
        // Render player
        Console.SetCursorPosition(playerX, playerY);
        Console.Write(playerChar);

        // Render asteroids
        foreach (var asteroid in asteroids)
        {
            Console.SetCursorPosition(asteroid[0], asteroid[1]);
            Console.Write(asteroidChar);
        }

        // Render bullets
        foreach (var bullet in bullets)
        {
            Console.SetCursorPosition(bullet[0], bullet[1]);
            Console.Write(bulletChar);
        }
    }
}
