﻿using System;
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

        public List<Player> StartPlayers(int playerCountWish)
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

        public Player GetPlayer(List<Player> playerList, int id)
        {
            foreach (var item in playerList)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        //game -- number given in pins is the pins struck down each roll
        public List<string> RunGame(List<Round> activerounds, List<Player> activeplayers, int pins)
        {
            var message = new List<string>();
            var playercount = activeplayers.Count;

            for (int i = 0; i < playercount; i++)
            {
                while (activerounds[i].Done() == false)
                {
                    activerounds[i].Roll(pins);
                }
                if (activerounds[i].Done())
                {
                    activeplayers[i].SaveGame(activerounds[i].Score());
                }
                message.Add(activeplayers[i].Name + activeplayers[i].ShowHistory().ToString());
            }
            return message;
        }
    }
    
}
