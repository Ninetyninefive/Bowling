using System;

namespace BowlingLibrary
{
    public class Round
    {
        private int _id;
        private int[] pinFalls = new int[21];
        private int rollCounter;
        private int _spareCounter;
        private int _strikeCounter;
        private int _currentFrame;
        private bool _isComplete;

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
        public int SpareCounter
        {
            get { return _spareCounter; }
            private set { _spareCounter = value; }
        }
        public int StrikeCounter
        {
            get { return _strikeCounter; }
            private set { _strikeCounter = value; }
        }
        public int CurrentFrame
        {
            get { return _currentFrame; }
            private set { _currentFrame = value; }
        }
        public bool IsComplete
        {
            get { return _isComplete; }
            private set { _isComplete = value; }
        }

        public void Roll(int pins)
        {
        
            if (pins > 10)
            {
                pins = 10;
            }

            if (pins < 0)
            {
                pins = 0;
            }


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

        public int Index()
        {
            return 0;
        }
        public bool Done()
        {
            
            if((rollCounter > 20) || (Score() == 300))
            {
                return _isComplete = true;
            }
            if((_strikeCounter > 10) || (_spareCounter > 10))
            {
                return _isComplete = true;
            }
            else if (CurrentFrame == 21)
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
                    _strikeCounter++;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                    _spareCounter++;
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
