using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace Bowling.UnitTest
{
    [TestClass]
    public class BowlingTests
    {
        [TestMethod]
        public void PlayerSelectionOnlyAcceptsNumbersOneToFour()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(4);

            Assert.AreEqual(actual, 4);
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
