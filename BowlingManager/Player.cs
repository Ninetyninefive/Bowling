using System;
using System.Linq;
using System.Collections.Generic;
using BowlingLibrary;
using System.IO;


namespace BowlingManager
{
    public class Player
    {

        // Identifiers
        private string _name;
        private int _id;
        private List<int> _history = new List<int>();
        public int _incoming;
        // Stats

        public Player()
        {
            _name = Name;
            _id = Id;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value;}
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public void SaveGame(int GameScore)
        {
            _history.Add(GameScore);
        }

        public string ShowHistory()
        { var message = "";
            message = string.Join(',', _history);
            return message;
        }

    }

}

