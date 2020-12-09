using System;

namespace BowlingLibrary
{
    public class Round
    {
        private int _id;
        private int[] _pinFalls = new int[21];
        private int _rollCounter;
        private bool _isBonus;
        private int _currentFrame;
        private bool _isComplete;
        private string _message = "";

        public Round()
        {
            _id = Id;
            _isComplete = IsComplete;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public bool IsBonus
        {
            get { return _isBonus; }
            private set { _isBonus = value; }
        }

        public void Roll(int pins)
        {
                if (pins > 10)
                {
                    pins = 10;
                    CurrentFrame += 2;
                }

                if (pins < 0)
                {
                    pins = 0;
                }

                _pinFalls[_rollCounter] = pins;
                _rollCounter++;
                CurrentFrame++;
        }

        private bool IsStrike(int frameIndex)
        {
            return _pinFalls[frameIndex] == 10;
        }

        private bool IsSpare(int frameIndex)
        {
            return _pinFalls[frameIndex] + _pinFalls[frameIndex + 1] == 10;
        }

        private int StrikeBonus(int frameIndex)
        {
            return _pinFalls[frameIndex + 1] + _pinFalls[frameIndex + 2];

        }

        private int SpareBonus(int frameIndex)
        {
            return _pinFalls[frameIndex + 2];
        }

        private bool TenthFrameBonus()
        {
            return _pinFalls[18] + _pinFalls[19] == 10;
        }

        public bool Done()
        {
            if(_rollCounter < 18 &&  CurrentFrame > 18 && !TenthFrameBonus())
            {
                return _isComplete = true;
            }
            if (CurrentFrame > 18 && !TenthFrameBonus())
            {
                if(!TenthFrameBonus())
                return _isComplete = true;
            }
            if (CurrentFrame > 18 && TenthFrameBonus())
            {
                return _isComplete = false;
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
                    score += _pinFalls[frameIndex] + _pinFalls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }

        
    }
}
