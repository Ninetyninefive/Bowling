using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace Bowling.UnitTest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void PlayerAmountReturnsValidAmount()
        {
            var newValidation = new Validation();
            
            Assert.AreEqual(newValidation.ValidateAmountOfPlayers(1), 1);

            Assert.AreEqual(newValidation.ValidateAmountOfPlayers(2), 2);

            Assert.AreEqual(newValidation.ValidateAmountOfPlayers(3), 3);

            Assert.AreEqual(newValidation.ValidateAmountOfPlayers(4), 4);

            Assert.AreEqual(newValidation.ValidateAmountOfPlayers(-1), 1);

            Assert.AreEqual(newValidation.ValidateAmountOfPlayers(5), 4);

            Assert.AreEqual(newValidation.ValidateAmountOfPlayers(-99995), 1);

            Assert.AreEqual(newValidation.ValidateAmountOfPlayers(999), 4);
        }

        [TestMethod]
        public void PlayerSelectionSetTooLowSetOne()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(-1);

            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void PlayerSelectionSetTooHighSetFour()
        {
            var newValidation = new Validation();

            var actual = newValidation.ValidateAmountOfPlayers(5);

            Assert.AreEqual(actual, 4);
        }
    }
}
