using System;

namespace RPS
{
    class AlwaysRock : Player
    {
        public override string OpponentName()
        {
            string opponentName = "Gollum";
            return opponentName;
        }

        public override string GenerateRPS()
        {
            string opponentThrow = "Rock";
            return opponentThrow;
        }
    }
}