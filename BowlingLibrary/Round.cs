﻿using System;

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
        private bool _isBonus;

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
                
            }
            if (pins < 0)
            {
                pins = 0;
            }
            if (pins >= 10)
            {
                _currentFrame += 2;
            }
            else
            {
                _currentFrame += 1;
            }
            pinFalls[rollCounter] = pins;
            rollCounter++;
            }
        private bool BonusRound()
        {
            return (pinFalls[18] + pinFalls[19] == 10);
        }
        private bool IsStrike(int frameIndex)
        {
            return pinFalls[frameIndex] == 10;
        }

        private bool IsSpare(int frameIndex)
        {
            return pinFalls[frameIndex] + pinFalls[frameIndex + 1] == 10;
        }

        private int StrikeBonus(int frameIndex)
        {
            return pinFalls[frameIndex + 1] + pinFalls[frameIndex + 2];

        }

        private int SpareBonus(int frameIndex)
        {
            return pinFalls[frameIndex + 2];
        }

        public bool Done()
        {
            
            if((rollCounter > 20) || (Score() == 300))
            {
                return _isComplete = true;
            }
            if (CurrentFrame > 18 && (!BonusRound()))
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
