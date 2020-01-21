using System;
using System.Threading;
using BlindSapper.CharacterControl;
using BlindSapper.Constants;
using BlindSapper.Visualisation;

namespace BlindSapper.GameController
{
    public class GameMaster
    {
        private CharacterController CharacterController { get; set; } = new CharacterController();
        public Position StartPosition { get; set; }
        public Position FinishPosition { get; set; }

        public void GameStart()
        {
            ConsoleWriter.FinishPosition = FinishPosition;
            CharacterController.CurrentCharacterPosition = StartPosition;
            while (true) 
            {
                if (CharacterController.CurrentCharacterPosition.x == FinishPosition.x
                    && CharacterController.CurrentCharacterPosition.y == FinishPosition.y)
                {
                    ConsoleWriter.CurrentScore += 10;
                    GameEnd();
                    break;
                }

            }
        }

        public void GameEnd()
        {
            ConsoleWriter.RefreshConsoleWindow();
            Console.WriteLine("level finished , do you want to continue?");
        }
    }
}