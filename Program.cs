using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new DiceResult();
            var rs = new RollService();
            result = rs.Result(20, 1, 0);
            Console.WriteLine("Dice result: " + result.Sum);
        }
    }
}