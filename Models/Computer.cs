namespace NumberGuess.Models
{

    public enum DifficultyLevelEnum
    {
        Easy,
        Medium,
        Hard
    }
    public class Computer
    {
        public int GeneratedNumber { get; private set; }
        public DifficultyLevelEnum DifficultyLevel { get; set; }


        public int GenerateNumber()
        {
            Random random = new();
            int x = random.Next(1, 101);
            GeneratedNumber = x;
            return x;
        }
    }
}