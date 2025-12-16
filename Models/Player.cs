namespace NumberGuess.Models
{
    public class Player()
    {

        public int Attempts { get; set; } = 0;

        public void IncrementAttempts()
        {
            Attempts++;
        }
    }
}