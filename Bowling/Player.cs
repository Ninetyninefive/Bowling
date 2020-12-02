using System;
using System.Collections.Generic;
using Bowling;
using BowlingLibrary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bowling
{
    public class Player
    {

        // Identifiers
        private int _id;
        private string _name;

        // Stats

        public Player()
        {
            _id = Id;
            _name = Name;
        }

        public int Id
        {
            get { return _id; }
            set {_id = value;}
        }

        public string Name
        {
            get { return _name; }
            set { _name = value;}
        }

                
    }
}

