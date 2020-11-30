using BowlingLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BowlingLibrary.UnitTest
{
    [TestClass]
    public class RoundTest
    {
        [TestMethod]
        public void Round_ReturnsCorrectAmmount()
        {

            var bowlinground1 = new Round();

            var actual = bowlinground1.Roll(8);


            Assert.IsTrue(actual);
        }
    }
}
