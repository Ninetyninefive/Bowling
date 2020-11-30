using BowlingLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BowlingLibrary.UnitTest
{
    [TestClass]
    public class RoundTest
    {

        [TestMethod]
        public void ReturnsCorrectAmmount()
        {

            var bowlinground1 = new Round();

            bowlinground1.Roll(8);


            Assert.AreEqual(bowlinground1.Score(), 8);
        }

        [TestMethod]
        public void ReturnsNoMorePinsThenZero()
        {

            var bowlinground1 = new Round();

            bowlinground1.Roll(-5);


            Assert.AreEqual(bowlinground1.Score(), 0);
        }

        [TestMethod]
        public void ReturnsNoMorePinsThenTen()
        {
            var bowlinground1 = new Round();

            bowlinground1.Roll(20);

            Assert.AreEqual(bowlinground1.Score(), 10);
        }

        [TestMethod]
        public void ReturnsScore()
        {
            var bowlinground1 = new Round();
            bowlinground1.Roll(20);

            Assert.AreEqual(bowlinground1.Score(), 10);
        }

        [TestMethod]
        public void GutterGame()
        {

            var bowlinground1 = new Round();

            for (int i = 0; i < 20; i++)
            {
                bowlinground1.Roll(0);
            }


            Assert.AreEqual(bowlinground1.Score(), 0);
        }

        [TestMethod]
        public void RollOnes()
        {
            var bowlinground1 = new Round();
            for (int i = 0; i < 20; i++)
            {
                bowlinground1.Roll(1);
            }
            
            Assert.AreEqual(bowlinground1.Score(), 20);
        }

    }
}
