using System;

namespace BlindSapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Orientation obj = NearMinesLeft;
            obj += NearMinesRight;
            obj += NearMinesDown;
            obj += NearMinesUp;

            Player p1 = new Player();
           
            bool[,] map = new bool[5,5] {
            { true, true, true, false,false },
            { false,false, true, true, true, },
            { true, true, true, true,false },
            { false, true, false, true,true },
            { false, false, false, false,true }
            };
           
            obj(p1, map, 5);
            
        }

        //void CreateMap() 
        //{
        //    bool[,] map = new bool[5, 5] {
        //    { false, true, true, false,false },
        //    { true,false, true, true, true, },
        //    { true, true, true, true,false },
        //    { false, true, false, true,true },
        //    { false, false, false, false,true }
        //    };

        //}
        static void NearMinesDown(Player player, bool[,] arr, int N)
        {
            int j = player.Xpos;

            for (int i = player.Ypos; i < N; i++)
            {
                if (arr[i, j] == false)
                {
                    int buff = i - player.Ypos;
                    Console.WriteLine($"Мина через {Math.Abs(buff) - 1} клетки вниз");
                    break;
                }
            }
        }
        static void NearMinesRight(Player player, bool[,] arr, int N)
        {
            int i = player.Ypos;

            for (int j = player.Xpos; j < N; j++)
            {
                if (arr[i, j] == false)
                {
                    int buff = j - player.Xpos;
                    Console.WriteLine($"Мина через {Math.Abs(buff) - 1} клетки вправо");
                    break;
                }
            }
        }
        static void NearMinesUp(Player player, bool[,] arr, int N)
        {
            int j = player.Xpos;

            for (int i = player.Ypos; i >= 0; i--)
            {
                if (arr[i, j] == false)
                {
                    int buff = player.Ypos - i;
                  
                    Console.WriteLine($"Мина через {Math.Abs(buff) - 1} клетки вверх");
                    break;
                }
            }
        }
        static void NearMinesLeft(Player player, bool[,] arr, int N)
        {
            int i = player.Ypos;

            for (int j = player.Xpos; j >= 0; j--)
            {
                if (arr[i, j] == false)
                {
                    int buff = j - player.Xpos;
                    
                    Console.WriteLine($"Мина через {Math.Abs(buff) - 1} клетки влево");
                    break;
                }
            }
        }

        public delegate void Orientation(Player player, bool[,] arr, int N);
    }

    public class Player
    {
        public int Xpos { get; set; } = 0;
        public int Ypos { get; set; } = 0;
    }
}    