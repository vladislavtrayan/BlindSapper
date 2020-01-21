using System;
using BlindSapper.CharacterControl;
using BlindSapper.Constants;
using BlindSapper.GameController;
using BlindSapper.Visualisation;

namespace BlindSapper
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMaster gameMaster = new GameMaster();
            gameMaster.FinishPosition = new Position
            {
                x = 25,
                y = 25
            };
            gameMaster.StartPosition = new Position
            {
                x = 2,
                y = 2
            };
            gameMaster.GameStart();
            Console.ReadKey();
        }
    }
}    