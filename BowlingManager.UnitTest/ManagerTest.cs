using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingManager;
using System.Collections.Generic;
using System;
using System.Linq;
using BowlingLibrary;
using System.IO;

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
        public void PlayerCreation()
        {
            List<Player> empty = new List<Player>();
            var manager = new Manager();

            var playerList = manager.NewGame(4);

            int[] idcheck = new int[4];

            for (int i = 0; i < playerList.Count; i++)
            {
                foreach (var item in playerList)
                {
                    if (item.Id == i)
                    {
                        idcheck[i] = item.Id;
                    }
                }
            }
            Assert.AreEqual(idcheck[3], 3);
        }

        [TestMethod]
        public void PlayersRollGameAllStrike()
        {
            var actual = 0;
            var manager = new Manager();
            
            var playerList = manager.NewGame(4);
            var roundList = manager.StartRounds(4);

            for (int i = 0; i < playerList.Count; i++)
            {
                foreach (var player in playerList)
                {
                    foreach (var gamee in roundList)
                    {
                        if(gamee.Id == player.Id)
                        {
                            gamee.Roll(10);
                            gamee.Score();
                            player.SaveGame(gamee.Score());
                            actual = Convert.ToInt32(player.ShowHistory());
                        }
                    }
                }
            }

            

            Assert.AreEqual(actual, 10);
        }

    }
}

