using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis
{
    public class Tennis
    {
        public static string GetScore(int playerOneScore, int playerTwoScore)
        {
            if (IsValidInput(playerOneScore, playerTwoScore))
                return "Invalid input";

            if (IsDeuce(playerOneScore, playerTwoScore))
                return "Deuce";

            if (IsAdvantage(playerOneScore, playerTwoScore))
                return "Advantage";

            if (HasWinner(playerOneScore, playerTwoScore))
                return Math.Max(playerOneScore, playerTwoScore) == playerOneScore ? "Player1 Win" : "Player2 Win";

            return GetTwoPlayerScore(playerOneScore, playerTwoScore);
        }

        private static bool IsValidInput(int playerOneScore, int playerTwoScore)
        {
            return playerOneScore + playerTwoScore < 0;
        }

        private static bool IsDeuce(int playerOneScore, int playerTwoScore)
        {
            return (playerOneScore == playerTwoScore) && (playerOneScore + playerTwoScore > 0);
        }

        private static bool IsAdvantage(int playerOneScore, int playerTwoScore)
        {
            return playerOneScore + playerTwoScore > 4 && Math.Abs(playerOneScore - playerTwoScore) == 1;
        }

        private static bool HasWinner(int playerOneScore, int playerTwoScore)
        {
            return playerOneScore + playerTwoScore > 4 && Math.Abs(playerOneScore - playerTwoScore) > 1;
        }

        private static string GetTwoPlayerScore(int playerOneScore, int playerTwoScore)
        {
            var scoreDic = new Dictionary<int, string>()
            {
                { 0, "Love" },
                { 1, "Fifteen" },
                { 2, "Thirty" },
                { 3, "Forty" }
            };
            return scoreDic[playerOneScore] + " " + scoreDic[playerTwoScore];
        }
    }
}
