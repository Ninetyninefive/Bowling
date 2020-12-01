using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace Bowling.UnitTest
{
    [TestClass]
    public class PlayerSelectValidation
    {
        [TestMethod]
        public void PlayerSelectionOnlyAcceptsNumbersOneToFour()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(4);

            Assert.AreEqual(actual, 4);
        }

        [TestMethod]
        public void PlayerSelectionOnlyAcceptsNumbersOneToFourOneTest()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(1);

            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void PlayerSelectionOnlyAcceptsNumbersOneToFourTwoTest()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(2);

            Assert.AreEqual(actual, 2);
        }

        [TestMethod]
        public void PlayerSelectionOnlyAcceptsNumbersOneToFourThreeTest()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(3);

            Assert.AreEqual(actual, 3);
        }

        [TestMethod]
        public void PlayerSelectionOnlyAcceptsNumbersOneToFourFourTest()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(4);

            Assert.AreEqual(actual, 4);
        }

        [TestMethod]
        public void PlayerSelectionReturnsZeroIfUnderOne()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(-1);

            Assert.AreEqual(actual, 0);
        }

        [TestMethod]
        public void PlayerSelectionReturnsZeroIfOverFour()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(5);

            Assert.AreEqual(actual, 0);
        }

        [TestMethod]
        public void PlayerSelectionRejectsNumbersLessThen1()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(-1);

            Assert.AreEqual(actual, 0);
        }

        [TestMethod]
        public void PlayerSelectionRejectsNumbersMoreThen4()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(5);

            Assert.AreEqual(actual, 0);
        }
    }
}
