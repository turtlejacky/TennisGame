using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame.Tests
{
    [TestClass()]
    public class TennisGameTests
    {
        private readonly TennisGame _tennisGame = new TennisGame("Federer", "Nadal");


        [TestMethod()]
        public void Love_All()
        {
            TheScoreShouldBe("Love All");
        }

        [TestMethod()]
        public void Fifteen_Love()
        {
            FirstPlayerScoreTimes(1);
            TheScoreShouldBe("Fifteen Love");
        }
        [TestMethod()]
        public void Thirty_Love()
        {
            FirstPlayerScoreTimes(2);
            TheScoreShouldBe("Thirty Love");
        }
        [TestMethod()]
        public void Forty_Love()
        {
            FirstPlayerScoreTimes(3);
            TheScoreShouldBe("Forty Love");
        }
        [TestMethod()]
        public void Love_Fifteen()
        {
            SecondPlayerScoreTimes(1);
            TheScoreShouldBe("Love Fifteen");
        }
        [TestMethod()]
        public void Love_Thirty()
        {
            SecondPlayerScoreTimes(2);
            TheScoreShouldBe("Love Thirty");
        }
        [TestMethod()]
        public void Love_Forty()
        {
            SecondPlayerScoreTimes(3);
            TheScoreShouldBe("Love Forty");
        }
        [TestMethod()]
        public void Fifteen_All()
        {
            FirstPlayerScoreTimes(1);
            SecondPlayerScoreTimes(1);
            TheScoreShouldBe("Fifteen All");
        }
        [TestMethod()]
        public void Thirty_All()
        {
            FirstPlayerScoreTimes(2);
            SecondPlayerScoreTimes(2);
            TheScoreShouldBe("Thirty All");
        }
        [TestMethod()]
        public void Duece_3_3()
        {
            FirstPlayerScoreTimes(3);
            SecondPlayerScoreTimes(3);
            TheScoreShouldBe("Duece");
        }
        [TestMethod()]
        public void Duece_4_4()
        {
            FirstPlayerScoreTimes(4);
            SecondPlayerScoreTimes(4);
            TheScoreShouldBe("Duece");
        }

        [TestMethod()]
        public void FirstPlayer_Adv()
        {
            FirstPlayerScoreTimes(6);
            SecondPlayerScoreTimes(5);
            TheScoreShouldBe("Federer Adv");
        }

        [TestMethod()]
        public void SecondPlayer_Adv()
        {
            FirstPlayerScoreTimes(3);
            SecondPlayerScoreTimes(4);
            TheScoreShouldBe("Nadal Adv");
        }
        [TestMethod()]
        public void FirstPlayer_Win()
        {
            FirstPlayerScoreTimes(5);
            SecondPlayerScoreTimes(3);
            TheScoreShouldBe("Federer Win");
        }
        [TestMethod()]
        public void SecondPlayer_Win()
        {
            FirstPlayerScoreTimes(3);
            SecondPlayerScoreTimes(5);
            TheScoreShouldBe("Nadal Win");
        }

        private void FirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerScore();
            }
        }
        private void SecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerScore();
            }
        }
        private void TheScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}