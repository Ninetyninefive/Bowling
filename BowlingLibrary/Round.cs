using System;

namespace BowlingLibrary
{
    public class Round
    {
        int _score;

        public Round()
        {

        }

        public void Roll(int pins)
        {
            if (pins > 10) { pins = 10; }
                
            if (pins < 0) { pins = 0; }

            _score += pins;
        }

        public int Score()
        {

            return _score;
        }
    }
}
