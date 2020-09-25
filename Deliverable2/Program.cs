using System;
using System.Globalization;
namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess which will have more: heads or tails? ");
            string headsOrTailsGuess = Console.ReadLine().ToLower();
            Console.Write("How many times shall we flip a coin? ");
            int numberOfFlips = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int count = 0;
            decimal correctCount = 0;
            while (count < numberOfFlips)
            {
                Random rnd = new Random();
                int result = rnd.Next(0, 2);
                if (result == 1)
                {
                    if (headsOrTailsGuess == "tails")
                    {
                        correctCount += 1;
                    }
                    Console.WriteLine("tails");
                    count += 1;
                }
                else if (result == 0)
                {
                    if (headsOrTailsGuess == "heads")
                    {
                        correctCount += 1;
                    }
                    Console.WriteLine("heads");
                    count += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Your guess, {headsOrTailsGuess}, came up {correctCount} times (s).");
            decimal coinTossPercentage = correctCount / numberOfFlips;
            Console.WriteLine($"That's {coinTossPercentage.ToString("P", CultureInfo.InvariantCulture)}");
        }
    }
}