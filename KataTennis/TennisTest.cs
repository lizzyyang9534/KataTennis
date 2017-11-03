using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTennis
{
    [TestClass]
    public class TennisTest
    {
        [TestMethod]
        public void TestGameStart()
        {
            string actual = Tennis.GetScore(0, 0);
            Assert.AreEqual("Game Start", actual);
        }

        [TestMethod]
        public void TestLoveFifteen()
        {
            string actual = Tennis.GetScore(0, 15);
            Assert.AreEqual("Love Fifteen", actual);
        }

        [TestMethod]
        public void TestLoveThirty()
        {
            string actual = Tennis.GetScore(0, 30);
            Assert.AreEqual("Love Thirty", actual);
        }

        [TestMethod]
        public void TestLoveForty()
        {
            string actual = Tennis.GetScore(0, 40);
            Assert.AreEqual("Love Forty", actual);
        }

        [TestMethod]
        public void TestFifteenLove()
        {
            string actual = Tennis.GetScore(15, 0);
            Assert.AreEqual("Fifteen Love", actual);
        }

        [TestMethod]
        public void TestDeuce()
        {
            string actual = Tennis.GetScore(40, 40);
            Assert.AreEqual("Deuce", actual);
        }

        [TestMethod]
        public void TestAdvantage()
        {
            string actual = Tennis.GetScore(40, 30);
            Assert.AreEqual("Advantage", actual);
        }

    }
}
