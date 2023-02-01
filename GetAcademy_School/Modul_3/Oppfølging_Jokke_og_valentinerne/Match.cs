using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokke_og_valentinerne
{
    internal class Match
    {
        // So this will run from start
        public bool MatchIsRunning = true;
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public string Bet { get; set; }

        public Match(string bet)
        {
            Bet = bet;

        }

        public void Stop()
        {
            MatchIsRunning = false;

        }


        public void GoalScore(bool isHomeTeam)
        {

            if (isHomeTeam) HomeGoals++;
            
            else AwayGoals++;
            GoalResult();

        }

        public void GoalResult()
        {
            Console.WriteLine($"Stillingen er {HomeGoals}-{AwayGoals}.");


        }

        public void BettingResult()
        {

            var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
            var isBetCorrect = Bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");

        }


        public void RunMatch()
        {
            while (MatchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") Stop();

                if (command == "H") GoalScore(true);
                else if (command == "B") GoalScore(false);

            }

        }
    }
}
