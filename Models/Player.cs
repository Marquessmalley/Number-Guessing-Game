namespace NumberGuess.Models
{
    public class Player()
    {

        public int Attempts { get; set; } = 1;
        public int MaxAttempts { get; set; } = 0;

        public void IncrementAttempts()
        {
            Attempts++;
        }
    }
}