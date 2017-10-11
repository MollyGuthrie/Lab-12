using System;

namespace RPS
{
    class GamePlay
    {
        Player opponent = null;

        public GamePlay()
        {
            string playerName = GetUserName();
            SelectOpponent(playerName);

            string sameOpponent = "Y";
            while (sameOpponent == "Y" || sameOpponent == "y")
            {
                string playerThrow = PlayerThrow();
                string opponentThrow = OpponentThrow(opponent);
                whoPickedWhat(playerName, playerThrow, opponent, opponentThrow);

                Console.Write("\nPlay again? (Y/N): ");
                sameOpponent = Console.ReadLine();
            }
        }

        public static string GetUserName()
        {
            Console.Write("\nEnter your name: ");
            string playerName = Console.ReadLine();

            return playerName;
        }

        public Player SelectOpponent(string playerName)
        {
            Console.WriteLine("\nWould you like to play against Smeagol or Gollum? (1 or 2)?");
            int opponentNum = int.Parse(Console.ReadLine());
            while (opponentNum < 1 || opponentNum > 2)
            {
                Console.Write("Not a valid selection. Please try again: ");
                opponentNum = int.Parse(Console.ReadLine());
            }
            switch (opponentNum)
            {
                case 1:
                    opponent = new AlwaysRock();
                    break;
                case 2:
                    opponent = new Smeagol();
                    break;
            }

            return opponent;
        }

        public static string PlayerThrow()
        {
            string playerPick = string.Empty;
            while (playerPick != "r" && playerPick != "p" && playerPick != "s")
            {
                Console.Write("\nRock, Paper, or Scissors? (R/P/S): ");
                playerPick = Console.ReadLine();
                playerPick = playerPick.ToLower();
            }
            if (playerPick == "r")
            {
                playerPick = "Rock";
            }
            else if (playerPick == "p")
            {
                playerPick = "Paper";
            }
            else if (playerPick == "s")
            {
                playerPick = "Scissors";
            }
            return playerPick;
        }

        public static string OpponentThrow(Player opponent)
        {
            string opponentThrow = opponent.GenerateRPS();
            return opponentThrow;
        }

        public static void whoPickedWhat(string playerName, string playerThrow, Player opponent, string opponentThrow)
        {
            Console.WriteLine("\n" + playerName + ": " + playerThrow);
            Console.WriteLine(opponent.OpponentName() + ": " + opponentThrow);
            Console.WriteLine();
        }
    }
}