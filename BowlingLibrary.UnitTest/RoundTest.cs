using BowlingLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BowlingLibrary.UnitTest
{
    [TestClass]
    public class RoundTest
    {
        Round game = new Round();


        public void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                if(rolls > 20)
                {
                    rolls = 20;
                }
                game.Roll(pins);
            }
        }

        [TestMethod]
        public void ReturnsCorrectAmmount()
        {
            game.Roll(8);

            Assert.AreEqual(game.Score(), 8);
        }

        [TestMethod]
        public void ReturnsNoMorePinsThenZero()
        {
            game.Roll(-5);

            Assert.AreEqual(game.Score(), 0);
        }

        [TestMethod]
        public void ReturnsNoMorePinsThenTen()
        {

            game.Roll(20);

            Assert.AreEqual(game.Score(), 10);
        }

        [TestMethod]
        public void ReturnsScore()
        {
            game.Roll(20);

            Assert.AreEqual(game.Score(), 10);
        }

        [TestMethod]
        public void RollGutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(game.Score(), 0);
        }

        [TestMethod]
        public void RollOnes()
        {
            RollMany(20, 1);
            
            Assert.AreEqual(game.Score(), 20);
        }


        [TestMethod]
        public void RollSpareFirstFrame()
        {
            game.Roll(9);
            game.Roll(1);
            RollMany(18, 1);
            Assert.AreEqual(game.Score(), 29);
        }

        [TestMethod]
        public void RollSpareEveryFrame()
        {
            
            RollMany(20, 5);
            Assert.AreEqual(game.Score(), 150);
        }

        [TestMethod]
        public void RollPerfectGame()
        {

            RollMany(12, 10);
            Assert.AreEqual(game.Score(), 300);
        }

        [TestMethod]
        public void RollNineOneSpares()
        {
            for(int i = 0; i < 10; i++)
            {
                game.Roll(9); game.Roll(1);
            }
            game.Roll(9);

            Assert.AreEqual(game.Score(), 190);
        }


        [TestMethod]
        public void RollTypicalGame()
        {
            game.Roll(10);
            game.Roll(9); game.Roll(1);
            game.Roll(5); game.Roll(5);
            game.Roll(7); game.Roll(2);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(9); game.Roll(0);
            game.Roll(8); game.Roll(2);
            game.Roll(9); game.Roll(1); game.Roll(10);



            Assert.AreEqual(game.Score(), 187);
        }


        [TestMethod]
        public void RollTooManyReturnsProperScore()
        {
            game.Roll(10);
            game.Roll(9); game.Roll(1);
            game.Roll(5); game.Roll(5);
            game.Roll(7); game.Roll(2);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(9); game.Roll(0);
            game.Roll(8); game.Roll(2);
            game.Roll(9); game.Roll(1); game.Roll(10);

            //RollTooMuch
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);

            Assert.AreEqual(game.Score(), 187);
        }

        [TestMethod]
        public void Roll21Ones()
        {
            RollMany(21, 1);

            Assert.AreEqual(game.Score(), 20);
        }

        [TestMethod]
        public void Roll13Strikes()
        {
            RollMany(13, 10);

            Assert.AreEqual(game.Score(), 300);
        }

        [TestMethod]
        public void ReturnRoundCompleteIf13Strikes()
        {
            RollMany(13, 10);


            Assert.AreEqual(game.Done(), true);
        }
        [TestMethod]
        public void ReturnRoundCompleteIf12Strikes()
        {
            RollMany(12, 10);


            Assert.AreEqual(game.Done(), true);
        }

        [TestMethod]
        public void ReturnRoundNotCompleteIf11Strikes()
        {
            RollMany(11, 10);


            Assert.AreEqual(game.Done(), false);
        }
        [TestMethod]
        public void ReturnRoundNotCompleteIf10Strikes()
        {
            RollMany(10, 10);


            Assert.AreEqual(game.Done(), false);
        }

        [TestMethod]
        public void TypicalGameReturnsValidEndState()
        {
            game.Roll(10);
            game.Roll(9); game.Roll(1);
            game.Roll(5); game.Roll(5);
            game.Roll(7); game.Roll(2);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            game.Roll(9); game.Roll(0);
            game.Roll(8); game.Roll(2);
            game.Roll(9); game.Roll(1); game.Roll(10);
            game.Score();
            Assert.AreEqual(game.Done(), true);
        }

        [TestMethod]
        public void AllGutterBallsReturnsProperEndState()
        {
            RollMany(21, 0);

            Assert.AreEqual(game.Done(), true);
        }

        [TestMethod]
        public void IndexBehaves()
        {
            game.Roll(1);
            game.Score();

            Assert.AreEqual(game.Index(), 1);
        }

        [TestMethod]
        public void FullTestGame()
        {
            game.Roll(1);
            game.Score();

            Assert.AreEqual(game.Index(), 1);
        }

    }
}
