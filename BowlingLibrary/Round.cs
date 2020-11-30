using System;

namespace BowlingLibrary
{
    public class Round
    {

        int[] pinFalls = new int[21];
        int rollCounter;

        public Round()
        {

        }

        public void Roll(int pins)
        {
            if (pins > 10) { pins = 10; }
                
            if (pins < 0) { pins = 0; }

            pinFalls[rollCounter] = pins;
            rollCounter++;
        }

        public int Score()
        {
            int score = 0;
            for(int i = 0; i <pinFalls.Length; i++)
            {
                score += pinFalls[i];
            }
            return score;
        }
    }
}
