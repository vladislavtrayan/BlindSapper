using System;
using BlindSapper.CharacterControl;
using BlindSapper.Constants;

namespace BlindSapper.Visualisation
{
    public static class СharacterVisualisation
    {
        public static char Symbol { get; set; } = '@';
    }
    
    public static class FinishVisualisation
    {
        public static char Symbol { get; set; } = '#';
    }
    public static class ConsoleWriter
    {
        public static Position СharacterPosition { get; set; } = new Position();
        public static Position FinishPosition { get; set; } = new Position();
        public static MineDistance MineDistance { get; set; } = new MineDistance();
        public static bool SpaceIsPressed { get; set; } = false;
        public static int CurrentScore { get; set; } = 0;

        public static void DrawScore(int score)
        {
            Console.Title = $"BlindSapper / Your current score is {score}";
        }

        public static void RedrawField()
        {
            RefreshConsoleWindow();
            DrawScore(CurrentScore);
            if(SpaceIsPressed)
                DrawMineDistances(СharacterPosition,MineDistance);
            
            DrawСharacter(СharacterPosition);
            DrawFinish(FinishPosition);
        }

        public static void DrawMineDistances(Position position,MineDistance mineDistance)
        {
            WriteAt(mineDistance.Bottom.ToString(), position.x, position.y - 1);
            WriteAt(mineDistance.Top.ToString(), position.x, position.y + 1);
            WriteAt(mineDistance.Left.ToString(), position.x - 1, position.y);
            WriteAt(mineDistance.Right.ToString(), position.x + 1, position.y);
        }

        public static void DrawСharacter(Position position)
        {    
            WriteAt(СharacterVisualisation.Symbol.ToString(), position.x, position.y);
        }
        
        public static void DrawFinish(Position position)
        {    
            WriteAt(FinishVisualisation.Symbol.ToString(), position.x, position.y);
        }

        public static void RefreshConsoleWindow()
        {
            Console.Clear();
        }

        private static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(0+x, 0+y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
    }
}