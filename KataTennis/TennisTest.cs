using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTennis
{
    [TestClass]
    public class TennisTest
    {
        [TestMethod]
        public void TestLoveLove()
        {
            string actual = Tennis.GetScore(0, 0);
            Assert.AreEqual("Love Love", actual);
        }

        [TestMethod]
        public void TestLoveFifteen()
        {
            string actual = Tennis.GetScore(0, 1);
            Assert.AreEqual("Love Fifteen", actual);
        }

        [TestMethod]
        public void TestLoveThirty()
        {
            string actual = Tennis.GetScore(0, 2);
            Assert.AreEqual("Love Thirty", actual);
        }

        [TestMethod]
        public void TestLoveForty()
        {
            string actual = Tennis.GetScore(0, 3);
            Assert.AreEqual("Love Forty", actual);
        }

        [TestMethod]
        public void TestFifteenLove()
        {
            string actual = Tennis.GetScore(1, 0);
            Assert.AreEqual("Fifteen Love", actual);
        }

        [TestMethod]
        public void TestDeuceOn3_3()
        {
            string actual = Tennis.GetScore(3, 3);
            Assert.AreEqual("Deuce", actual);
        }

        [TestMethod]
        public void TestDeuceOn4_4()
        {
            string actual = Tennis.GetScore(4, 4);
            Assert.AreEqual("Deuce", actual);
        }

        [TestMethod]
        public void TestDeuceOn5_5()
        {
            string actual = Tennis.GetScore(5, 5);
            Assert.AreEqual("Deuce", actual);
        }

        [TestMethod]
        public void TestAdvantageOn3_2()
        {
            string actual = Tennis.GetScore(3, 2);
            Assert.AreEqual("Advantage", actual);
        }

        [TestMethod]
        public void TestAdvantageOn3_4()
        {
            string actual = Tennis.GetScore(3, 4);
            Assert.AreEqual("Advantage", actual);
        }

        [TestMethod]
        public void TestAdvantageOn4_5()
        {
            string actual = Tennis.GetScore(4, 5);
            Assert.AreEqual("Advantage", actual);
        }

        [TestMethod]
        public void TestAdvantageOn5_6()
        {
            string actual = Tennis.GetScore(5, 6);
            Assert.AreEqual("Advantage", actual);
        }

        [TestMethod]
        public void TestPlayerOneWinOn4_1()
        {
            string actual = Tennis.GetScore(4, 1);
            Assert.AreEqual("Player1 Win", actual);
        }

        [TestMethod]
        public void TestPlayerOneWinOn4_2()
        {
            string actual = Tennis.GetScore(4, 2);
            Assert.AreEqual("Player1 Win", actual);
        }

        [TestMethod]
        public void TestPlayerOneWinOn5_3()
        {
            string actual = Tennis.GetScore(5, 3);
            Assert.AreEqual("Player1 Win", actual);
        }

        [TestMethod]
        public void TestPlayerOneWinOn6_4()
        {
            string actual = Tennis.GetScore(6, 4);
            Assert.AreEqual("Player1 Win", actual);
        }

        [TestMethod]
        public void TestPlayerTwoWinOn1_4()
        {
            string actual = Tennis.GetScore(1, 4);
            Assert.AreEqual("Player2 Win", actual);
        }

        [TestMethod]
        public void TestPlayerTwoWinOn2_4()
        {
            string actual = Tennis.GetScore(2, 4);
            Assert.AreEqual("Player2 Win", actual);
        }

        [TestMethod]
        public void TestPlayerTwoWinOn3_5()
        {
            string actual = Tennis.GetScore(3, 5);
            Assert.AreEqual("Player2 Win", actual);
        }

        [TestMethod]
        public void TestPlayerTwoWinOn4_6()
        {
            string actual = Tennis.GetScore(4, 6);
            Assert.AreEqual("Player2 Win", actual);
        }


        [TestMethod]
        public void TestInvalidInput()
        {
            string actual = Tennis.GetScore(-1, -2);
            Assert.AreEqual("Invalid input", actual);
        }

    }
}
