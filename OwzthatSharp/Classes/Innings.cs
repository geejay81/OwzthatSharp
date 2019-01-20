using System;
using System.Collections.Generic;

namespace OwzthatSharp
{
    public class Innings
    {
        private Team _battingTeam;
        private Team _bowlingTeam;
        private int _oversInInnings;
        public List<Over> Overs;

        public Innings(Team battingTeam, Team bowlingTeam, int oversInInnings)
        {
            _battingTeam = battingTeam;
            _bowlingTeam = bowlingTeam;
            _oversInInnings = oversInInnings;
            Overs = new List<Over>();
        }

        public void Simulate()
        {
            Console.WriteLine("Simulating innings for {0}", _battingTeam.Name);

            for (var o = 1; o <= _oversInInnings; o++)
            {
                var over = new Over(o);
                over.Simulate();
                Overs.Add(over);
            }
        }
    }
}