using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace Bowling.UnitTest
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void NewPlayerGetsUniqueGuidThatCannotBeChanged()
        {
            var player = new Player();

            Assert.AreEqual(player.Id, player.Id);
        }

        [TestMethod]
        public void NewPlayersGetUniqueGuid()
        {
            var player = new Player();
            var player2 = new Player();

        Assert.AreNotEqual(player.Id, player2.Id);
        }
        
    }

    }