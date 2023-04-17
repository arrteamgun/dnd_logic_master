using System.Collections;
using System.Collections.Generic;


public class DiceResult 
{
    public DiceResult()
    {
        Rolls = new List<int>();
    }

    public int Id {get; set;}
    public int DiceType {get; set;}
    public int NumberOfDice {get; set;}
    public int Modifier {get; set;}
    public List<int> Rolls {get; set;}
    public int Sum {get; set;}

    
}