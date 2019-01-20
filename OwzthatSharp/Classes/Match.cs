using System;
using System.Collections.Generic;

namespace OwzthatSharp
{
    public class Match
    {
        private Team _homeTeam;
        private Team _awayTeam;
        private int _inningsPerTeam;
        private int _oversPerInnings;
        private List<Innings> _innings;

        public Match(string homeTeamName, string awayTeamName, int inningsPerTeam, int oversPerInnings)
        {
            _homeTeam = new Team(homeTeamName);
            _awayTeam = new Team(awayTeamName);
            _inningsPerTeam = inningsPerTeam;
            _oversPerInnings = oversPerInnings;
            _innings = new List<Innings>();
        }

        public void Simulate()
        {
            Console.WriteLine("Match Started between {0} and {1}.", _homeTeam.Name, _awayTeam.Name);
            if (_oversPerInnings > 0)
                Console.WriteLine("{0} overs per innings", _oversPerInnings);

            for (var i = 1; i <= _inningsPerTeam; i++)
            {
                var firstInnings = new Innings(_homeTeam, _awayTeam, _oversPerInnings);
                firstInnings.Simulate();
                _innings.Add(firstInnings);
                var secondInnings = new Innings(_awayTeam, _homeTeam, _oversPerInnings);
                secondInnings.Simulate();
                _innings.Add(secondInnings);
            }
        }
    }
}