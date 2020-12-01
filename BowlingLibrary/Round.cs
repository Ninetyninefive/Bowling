using System;

namespace BowlingLibrary
{
    public class Round
    {
        private Guid _id;
        int[] pinFalls = new int[21];
        int rollCounter;

        public Round()
        {
            _id = Id;
        }

        public Guid Id
        {
            get { return _id; }
            private set
            {
                if (_id == (Guid.Empty))
                    _id = Guid.NewGuid();
                else
                { Console.WriteLine("This round has an uID -- Unbable to reset."); }
            }
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
            int frameIndex = 0;
            for(int frame = 0; frame < 10; frame++)
            {
                if(IsStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    frameIndex += 1;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += pinFalls[frameIndex] + pinFalls[frameIndex + 1];
                    frameIndex += 2;
                }
                
            }
            return score;
        }
    }
}
