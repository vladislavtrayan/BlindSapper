using System;
using System.Threading;
using BlindSapper.Constants;
using BlindSapper.Visualisation;

namespace BlindSapper.CharacterControl
{
    public class CharacterController
    {
        public Position CurrentCharacterPosition { get; set; } = new Position();

        public CharacterController()
        {
            new Thread(Controller).Start();
        }

        public void Controller()
        {
            while (true)
            {
                switch (ConsoleReader.ReadKeyFromConsole())
                {
                    case Keys.Space:
                        ShowNearMines();
                        break;
                    case Keys.ArrowUp:
                        MoveUp();
                        HideNearMines();
                        break;
                    case Keys.ArrowDown:
                        MoveDown();
                        HideNearMines();
                        break;
                    case Keys.ArrowLeft:
                        MoveLeft();
                        HideNearMines();
                        break;
                    case Keys.ArrowRight:
                        MoveRight();
                        HideNearMines();
                        break;
                    case Keys.Nothing:
                        HideNearMines();
                        break;
                }
                ConsoleWriter.RedrawField();
            }
        }
        
        public void ShowNearMines()
        {
            MineDistance mineDistance = new MineDistance // should be changed by real method
            {
                Top = 1,
                Bottom = 1,
                Left = 1,
                Right = 1
            };
            
            ConsoleWriter.MineDistance = mineDistance;
            ConsoleWriter.SpaceIsPressed = true;

        }
        
        public void HideNearMines()
        {
            ConsoleWriter.SpaceIsPressed = false;
        }

        public void MoveLeft()
        {
            if(CurrentCharacterPosition.x > 0)
                CurrentCharacterPosition.x --;
            ConsoleWriter.СharacterPosition = CurrentCharacterPosition;
        }

        public void MoveRight()
        {
            CurrentCharacterPosition.x ++;
            ConsoleWriter.СharacterPosition = CurrentCharacterPosition;
        }

        public void MoveUp()
        {
            if(CurrentCharacterPosition.y > 0)
                CurrentCharacterPosition.y --;
            ConsoleWriter.СharacterPosition = CurrentCharacterPosition;
        }

        public void MoveDown()
        {
            CurrentCharacterPosition.y ++;
            ConsoleWriter.СharacterPosition = CurrentCharacterPosition;
        }
    }
}