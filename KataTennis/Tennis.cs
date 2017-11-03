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
            var scoreDic = new Dictionary<int, string>()
            {
                { 0, "Love" },
                { 15, "Fifteen" },
                { 30, "Thirty" },
                { 40, "Forty" }
            };

            if (playerOneScore + playerTwoScore == 0)
                return "Game Start";

            if (playerOneScore == playerTwoScore)
                return "Deuce";

            return scoreDic[playerOneScore] + " " + scoreDic[playerTwoScore];
        }
    }
}
