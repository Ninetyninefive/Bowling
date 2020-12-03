using System;
using System.Linq;
using System.Collections.Generic;
using BowlingLibrary;
using System.IO;


namespace BowlingManager
{
    public class Manager
    {

        public Manager()
        {
            

        }

        public List<Player> NewGame(int playerCountWish)
        {
            var newValidation = new Validation();

            var playerCount = newValidation.ValidateAmountOfPlayers(playerCountWish);

            Player newPlayer = new Player();
            List<Player> playerList = new List<Player>();
            
            for (int i = 0; i < playerCount; i++)
            {
                newPlayer = new Player();
                newPlayer.Id = i;
                newPlayer.Name = $"Player {i}";
                playerList.Add(newPlayer);
            }
            return playerList;
        }

        public List<Round> StartRounds(int playerCountWish)
        {
            var newValidation = new Validation();

            var playerCount = newValidation.ValidateAmountOfPlayers(playerCountWish);

            Round newRound = new Round();
            List<Round> roundList = new List<Round>();

            for (int i = 0; i < playerCount; i++)
            {
                newRound = new Round();
                newRound.Id = i;
                roundList.Add(newRound);
            }
            return roundList;
        }

    }

    
}
