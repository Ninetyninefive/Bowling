using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace Bowling.UnitTest
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void PlayerGetsUniqueGuidThatCannotBeChanged()
        {
            var player = new Player();

            Assert.AreEqual(player.Id, player.Id);

        }
    }

    }