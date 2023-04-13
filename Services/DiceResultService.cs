public class RollService : IRollService
{
    public DiceResult Result(int diceType, int numberOfDice, int modifier)
    {
        var rolls = new List<int>();
        Random rand = new Random();

        for (int i = 0; i < numberOfDice; i++)
        {
            rolls.Add(rand.Next(1, diceType));
        }

        var result = new DiceResult
        {
            
        };

        return result;
    }
}