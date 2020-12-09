using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingManager;
using BowlingLibrary;
using System.Collections.Generic;
using System;
using System.Linq;

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

            var playerList = manager.StartPlayers(4);

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
            
            var manager = new Manager();
            var playerList = manager.StartPlayers(4);
            var roundList = manager.StartRounds(4);
            var result = manager.RunGame(roundList, playerList, 10);
            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FullStrikeGameFourPlayersThenNewGame()
        {

            var manager = new Manager();
            var playerList = manager.StartPlayers(4);
            var roundList = manager.StartRounds(4);
            var currentGame = manager.RunGame(roundList, playerList, 10);

            foreach (var item in currentGame)
            {
                Console.WriteLine(item);
            }

            var manager2 = new Manager();
            var playerList2 = manager.StartPlayers(4);
            var roundList2 = manager.StartRounds(4);
            var currentGame2 = manager.RunGame(roundList2, playerList2, 8);

            foreach (var item in currentGame2)
            {
                Console.WriteLine(item);
            }
            Assert.AreNotEqual(currentGame, currentGame2);
        }

        [TestMethod]
        public void PlayersRollGameAllStrikeReturnsCorrectScoreCard()
        {

            var manager = new Manager();
            var playerList = manager.StartPlayers(4);
            var roundList = manager.StartRounds(4);
            var currentGame = manager.RunGame(roundList, playerList, 10);

            foreach (var item in currentGame)
            {
                Console.WriteLine(item);
            }

            Assert.IsNotNull(currentGame);
        }

    }
}

