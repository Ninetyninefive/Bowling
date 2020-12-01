using System;
using System.Linq;
using BowlingLibrary;

namespace Bowling
{
    public class Validation
    {
        public Validation()
        {

            
        }
        public int ValidateAmountOfPlayers(int inputPlayerNumber)
        {
            var validNumber = new int[] { 1, 2, 3, 4 };
            
            if (validNumber.Contains(inputPlayerNumber))
                {
                return inputPlayerNumber;
                }
            else if(inputPlayerNumber>4)
            {
                return 4;
            }
            return 1;
        }
    }
}
