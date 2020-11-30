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
            int i = 0;
            for(int frame = 0; frame < 10; frame++)
            {
                if (pinFalls[i] + pinFalls[i+1]== 10)
                {
                    score += 10 + pinFalls[i + 2];
                    i += 1;
                }
                else
                {
                    score += pinFalls[i] + pinFalls[i + 2];
                    i += 1;
                }
                
            }
            return score;
        }
    }
}
