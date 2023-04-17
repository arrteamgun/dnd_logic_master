using System;
using System.Collections.Generic;

public class RollService : IRollService
{
    public DiceResult Result(int diceType, int numberOfDice, int modifier)
    {
        var rolls = new List<int>();
        var sum = 0;
        Random rand = new Random();

        for (int i = 0; i < numberOfDice; i++)
        {
            var rnd = rand.Next(1, diceType + 1 + modifier);
            rolls.Add(rnd);
            sum += rnd;
        }

        var result = new DiceResult
        {
            DiceType = diceType,
            NumberOfDice = numberOfDice,
            Modifier = modifier,
            Rolls = rolls,
            Sum = sum

        };

        return result;
    }
}