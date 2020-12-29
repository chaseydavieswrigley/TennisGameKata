using NUnit.Framework;

namespace TennisGameKata.Test
{
    public class Tests
    {
        public TennisGame tennisGame;

        [SetUp]
        public void Setup()
        {
           tennisGame = new TennisGame();
        }

        [Test]
        public void WhenGameStartsTheScoreIsLoveAll()
        {         
            Assert.AreEqual("Love all", tennisGame.Score());
        }

        [Test]
        public void WhenPlayerOneWinsFirstBallTheScoreIs15Love()
        {
            tennisGame.PlayerOneWinsBall();
            Assert.AreEqual("15 : Love", tennisGame.Score());
        }
        [Test]
        public void WhenPlayerTwoWinsFirstBallTheScoreIsLove15()
        {
            tennisGame.PlayerTwoWinsBall();
            Assert.AreEqual("Love : 15", tennisGame.Score());
        }

        [Test]
        public void WhenBothPlayersWinThreeBallsTheScoreIsDeuce()
        {
            for(int i =0; i < 3; i++)
            {
                tennisGame.PlayerTwoWinsBall();
                tennisGame.PlayerOneWinsBall();
            }
            Assert.AreEqual("Deuce", tennisGame.Score());
        }

        [Test]
        public void WhenBothPlayersWinFourBallsTheScoreIsBackToDeuce()
        {
            for (int i = 0; i < 4; i++)
            {
                tennisGame.PlayerTwoWinsBall();
                tennisGame.PlayerOneWinsBall();
            }
            Assert.AreEqual("Deuce", tennisGame.Score());
        }

        [Test]
        public void WhenPlayerOneWinFiveBallsTheGameIsWon()
        {
            for (int i = 0; i < 5; i++)
            {          
                tennisGame.PlayerOneWinsBall();
            }
            Assert.AreEqual("Player One Wins", tennisGame.Score());
        }
        [Test]
        public void WhenPlayerTwoWinFiveBallsTheGameIsWon()
        {
            for (int i = 0; i < 5; i++)
            {
                tennisGame.PlayerTwoWinsBall();
            }
            for (int i = 0; i < 4; i++)
            {
                tennisGame.PlayerOneWinsBall();
            }
            Assert.AreEqual("Player Two Wins", tennisGame.Score());
        }

        [Test]
        public void WhenPlayerTwoWinFourBallsTheScoreIsAdvPlayerTwo()
        {
            for (int i = 0; i < 4; i++)
            {
                tennisGame.PlayerTwoWinsBall();
            }
            for (int i = 0; i < 3; i++)
            {
                tennisGame.PlayerOneWinsBall();
            }
            Assert.AreEqual("Advantage Player Two", tennisGame.Score());
        }


    }
}