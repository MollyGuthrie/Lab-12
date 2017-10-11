using System;

namespace RPS
{
    class Smeagol : Player
    {
        public override string OpponentName()
        {
            string opponentName = "Smeagol";
            return opponentName;
        }

        public override string GenerateRPS()
        {
            Random rnd = new Random();
            string opponentPick = string.Empty;
            int oppThrow = rnd.Next(1, 4);
            switch (oppThrow)
            {
                case 1:
                    opponentPick = "Rock";
                    break;
                case 2:
                    opponentPick = "Paper";
                    break;
                case 3:
                    opponentPick = "Scissors";
                    break;
            }
            return opponentPick;
        }
    }


}