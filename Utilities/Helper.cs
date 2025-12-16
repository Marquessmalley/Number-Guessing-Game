using NumberGuess.Models;

namespace NumberGuess.Utility
{
    public static class GameHelper
    {
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
    }
}