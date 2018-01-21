using System;

namespace RockPaperScissors.Entities
{
    public class Game
    {
        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public Player Player1 { get; }
        public Player Player2 { get; }

        public GameResult Play()
        {
            Player winner = null;
            bool draw = false;

            var player1Wins = Attack(Player1, Player2);
            var player2Wins = Attack(Player2, Player1);

            if (player1Wins && player2Wins)
                throw new NotSupportedException("Cannot have 2 winners");
            else if ((player1Wins || player2Wins) == false)
                draw = true;
            else if (player1Wins)
                winner = Player1;
            else if (player2Wins)
                winner = Player2;

            var result = new GameResult(winner, draw);
            return result;
        }

        private bool Attack(Player from, Player to)
        {
            var firstAttackerWins = from.Hand.Strength == to.Hand.Weakness;
            return firstAttackerWins;
        }

        public class GameResult
        {
            public GameResult(Player winner, bool draw)
            {
                Winner = winner;
                Draw = draw;
            }
            public Player Winner { get; }

            public bool Draw { get; }
        }
    }
}
