using NumberGuess.Models;

namespace NumberGuess.Utility
{
    public static class GameHelper
    {

        public static bool ValidatePlayerGuess(Player player, int computerGenNum, int playerGuess)
        {
            if (player.Attempts == player.MaxAttempts)
            {
                Console.WriteLine($"\nThe target number was {computerGenNum}");
                Console.WriteLine("\nYou ran out of attempts, game over!");
                System.Environment.Exit(0);
            }


            if (playerGuess != computerGenNum)
            {
                HandleIncorrectGuess(computerGenNum, playerGuess);
                player.IncrementAttempts();
                return false;

            }


            return true;

        }
        public static int MaxAttempts(DifficultyLevelEnum level)
        {
            return level switch
            {
                DifficultyLevelEnum.Easy => 10,
                DifficultyLevelEnum.Medium => 5,
                DifficultyLevelEnum.Hard => 3,
                _ => 0,
            };
        }
        public static void CongratulatePlayer(Player player)
        {
            Console.WriteLine($"Congratulations! You guessed the correct number in {player.Attempts}");
            System.Environment.Exit(0);
        }
        private static void HandleIncorrectGuess(int computerGenNum, int playerGuess)
        {
            if (computerGenNum > playerGuess)
            {
                Console.WriteLine($"Incorrect! The number is higher than {playerGuess}");
            }
            if (playerGuess > computerGenNum)
            {
                Console.WriteLine($"Incorrect! The number is less than {playerGuess}");
            }
        }
    }
}