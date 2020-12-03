using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingManager;
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

        [TestMethod]
        public void SaveShowHistory()
        {
            var game1 = new Round();
            var player1 = new Player();
            player1.Name = "Dansken som skrev C++";
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            game1.Roll(10);
            var score1 = game1.Score();
            player1.SaveGame(score1);
            var scoreSaved = player1.ShowHistory();
            Assert.AreEqual(scoreSaved, "300");
        }
    }


}
