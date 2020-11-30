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

        bool IsStrike(int frameIndex)
        {
            return pinFalls[frameIndex] == 10;

        }

        bool IsSpare(int frameIndex)
        {
            return pinFalls[frameIndex] + pinFalls[frameIndex + 1] == 10;
        }

        int StrikeBonus(int frameIndex)
        {
            return pinFalls[frameIndex + 1] + pinFalls[frameIndex + 2];

        }

        int SpareBonus(int frameIndex)
        {
            return pinFalls[frameIndex + 2];
        }

        public int Score()
        {
            int score = 0;
            int i = 0;
            for(int frame = 0; frame < 10; frame++)
            {
                if(IsStrike(i))
                {
                    score += 10 + StrikeBonus(i);
                    i += 1;
                }
                else if (IsSpare(i))
                {
                    score += 10 + SpareBonus(i);
                    i += 2;
                }
                else
                {
                    score += pinFalls[i] + pinFalls[i + 1];
                    i += 2;
                }
                
            }
            return score;
        }
    }
}
