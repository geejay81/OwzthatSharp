using System;

namespace OwzthatSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Constants.Commands.GetHomeTeam);
            string homeTeam = Console.ReadLine();

            Console.Write(Constants.Commands.GetAwayTeam);
            string awayTeam = Console.ReadLine();

            Match match = new Match(homeTeam, awayTeam, 1, 50);

            match.Simulate();
        }
    }
}
