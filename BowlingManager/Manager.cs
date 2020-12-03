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

        public void NewGame()
        {
            var newValidation = new Validation();

            var playerCount = newValidation.ValidateAmountOfPlayers(Convert.ToInt32(Console.ReadLine()));

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

        }


    }

    
}
