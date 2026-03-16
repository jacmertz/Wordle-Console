/* 
    Wordle.cs

    This class contains the main game loop for the Wordle game. It handles user input, 
    checks guesses against the answer, and provides feedback on the guesses. The game 
    continues until the user either wins or chooses to play again. The user can select 
    their skill level, which determines the number of attempts allowed.
*/

using System;

public class Wordle
{
    public static void Main()
    {
        Words words = new Words();
        string playAgain = "Y";

        while (playAgain == "Y")
        {
            int tries = GetSkillLevel();
            string answer = words.GetRandomWord();
            Console.WriteLine("\nChosen Word: " + answer); // Leave this line for testing

            bool win = false;

            for (int attempt = 1; attempt <= tries; attempt++) {
                Console.Write("\nEnter guess " + attempt + ": ");
                string guess = Console.ReadLine().ToUpper();

                if (guess.Length != 5)
                {
                    Console.WriteLine("Please enter exactly 5 letters.");
                    attempt--;
                    continue;
                }

                string result = "";

                for (int i = 0; i < 5; i++) {
                    if (guess[i] == answer[i])
                        result += guess[i]; 
                    else if (answer.Contains(guess[i].ToString()))
                        result += "*"; 
                    else
                        result += "-"; 
                }

                Console.WriteLine(result);

                if (guess == answer)
                {
                    Console.WriteLine("You WON!");
                    win = true;
                    break;
                }
            }

            if (!win)
                Console.WriteLine("You LOST. The word was: " + answer);

            Console.Write("Play again? (Y/N): ");
            playAgain = Console.ReadLine().ToUpper();
        }
    }

    public static int GetSkillLevel()
    {
        Console.WriteLine("\n1 - Beginner (6 tries)");
        Console.WriteLine("2 - Proficient (4 tries)");
        Console.WriteLine("3 - Expert (3 tries)");

        while (true)
        {
            Console.Write("Choose skill level: ");
            string input = Console.ReadLine();

            if (input == "1") return 6;
            if (input == "2") return 4;
            if (input == "3") return 3;

            Console.WriteLine("Invalid input. Try again.");
        }
    }
}
