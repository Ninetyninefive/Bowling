using System;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {

            
            BowlingGame game = new BowlingGame();
            game.Run();

            Console.ReadKey();
            

        }
    }
}
