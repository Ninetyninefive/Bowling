using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingManager;
using BowlingLibrary;
using System.Collections.Generic;
using System.Linq;

namespace BowlingManager.UnitTest
{
    [TestClass]
    public class ManagerTest
    {
        [TestMethod]
        public void NewGameReturnsValidPlayerCount4()
        {

            var manager = new Validation();
            var actual = manager.ValidateAmountOfPlayers(5);


            Assert.AreEqual(actual, 4);
        }

        [TestMethod]
        public void NewGameReturnsValidPlayerCount1()
        {

            var manager = new Validation();
            var actual = manager.ValidateAmountOfPlayers(0);


            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void Nothing()
        {
            var newValidation = new Validation();

            var playerCount = newValidation.ValidateAmountOfPlayers(4);

            Player[] player = new Player[playerCount];
            Round[] round = new Round[playerCount];

            for (int i = 0; i < playerCount; i++)
            {
                foreach (var item in player)
                {
                    item.Id = i;
                    item.Name = $"Player {i}";
                }
            }

            Assert.AreEqual(player[1], "Player 1");
            Assert.AreEqual(player[2], "Player 2");
            Assert.AreEqual(player[3], "Player 3");
            Assert.AreEqual(player[4], "Player 4");
        }


    }
}
