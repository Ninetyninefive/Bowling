using System;

namespace BowlingLibrary
{
    public class Round
    {
        private int score;

        public Round()
        {

        }

        public int Roll(int pins)
        {
            if (pins > 10) { pins = 10; }
                
            if (pins < 0) { pins = 0; }

            score += pins;
            return score;
        }

        public int Score()
        {
            
            return 0;
        }
    }
}
