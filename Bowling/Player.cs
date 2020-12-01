using System;
using System.Collections.Generic;
using Bowling;
using BowlingLibrary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bowling
{

    [Serializable]
    public class Player
    {

        // Identifiers
        private Guid _id = Guid.NewGuid();
        private string _name;

        // Stats
        private int _games = 0;
        private List<Round> _history;

        public Player()
        {
            _id = Id;
            _name = Name;
            _games = Games;
            _history = History;
        }

        public Guid Id
        {
            get { return _id; }
            private set {Guid.NewGuid();}}


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public int Games
        {
            get { return _games; }
            set { _games = value; }
        }

        public List<Round> History
        {
            get { return _history; }
            set
            {
                _games++;
                _history = value;
            }
        }


    }
}
