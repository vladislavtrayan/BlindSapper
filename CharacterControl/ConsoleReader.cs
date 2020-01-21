using System;

namespace BlindSapper.CharacterControl
{
    public enum Keys
    {
      ArrowDown,
      ArrowUp,
      ArrowLeft,
      ArrowRight,
      Space,
      Nothing = -1
    }
    
    public static class ConsoleReader
    {
        public static Keys ReadKeyFromConsole()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Spacebar:
                    return Keys.Space;
                case ConsoleKey.DownArrow:
                    return Keys.ArrowDown;
                case ConsoleKey.UpArrow :
                    return Keys.ArrowUp;
                case ConsoleKey.LeftArrow:
                    return Keys.ArrowLeft;
                case ConsoleKey.RightArrow:
                    return Keys.ArrowRight;
                default:
                    return Keys.Nothing;
            }
        }
    }
}