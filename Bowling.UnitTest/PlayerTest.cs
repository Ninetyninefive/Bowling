using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;
using BowlingLibrary;
using System.Collections.Generic;
using System.Linq;

namespace Bowling.UnitTest
{
    [TestClass]
    public class PlayerTest
    {

        [TestMethod]
        public void NewPlayersCanHaveNames()
        {
            var player1 = new Player();
            player1.Name = "Dansken som skrev C++";

            var player2 = new Player();
            player2.Name = "Linus Torvalds";

            Assert.AreNotEqual(player1.Name, player2.Name);
        }

    }


}
