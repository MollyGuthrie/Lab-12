using System;

namespace RPS
{
    abstract class Player
    {
        public abstract string OpponentName();

        public abstract string GenerateRPS();
    }
}
