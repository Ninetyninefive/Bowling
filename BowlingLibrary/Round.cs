using System;

namespace BowlingLibrary
{
    public class Round
    {
        private int _id;
        int[] pinFalls = new int[21];
        public int rollCounter;
        bool _isComplete;

        public Round()
        {
            _id = Id;
            _isComplete = IsComplete;
        }

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public bool IsComplete
        {
            get { return _isComplete; }
            private set { _isComplete = value; }
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

        
        public bool Done()
        {
            if((pinFalls[20] > -1) && rollCounter >= 12)
            {
                return _isComplete = true;
            }
            else if((pinFalls[20] > -1) && rollCounter > 20)
            {
                return _isComplete = true;
            }
            else
            {
                return _isComplete = false;
            }
        }
        

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
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
