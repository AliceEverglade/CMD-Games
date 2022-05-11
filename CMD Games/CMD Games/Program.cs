using System;
using System.Threading;

namespace CMD_Games
{
    class Snake
    {
        public static Random random = new Random();
        public static string pixel = "██";
        public static string space = "  ";
        public static string food = "▄▀";
        public static string line;

        public static int height = 30;
        public static int width = 50;

        public static bool playing = false;

        public static string[,] playingField;
        public static int[] playerCords = new int[2];
        public static int[] FoodCords = new int[2];

        static void Main(string[] args)
        {
            // █ , ▄ , ▀
            Setup();
        }

        static void Setup()
        {

            playingField = new string[height,width];
            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if(i == 0 || i == height-1)
                    {
                        playingField[i, j] = pixel;
                    }
                    else if(j == 0 || j == width-1)
                    {
                        playingField[i, j] = pixel;
                    }
                    else
                    {
                        playingField[i, j] = space;
                    }
                }
            }
            playerCords[0] = random.Next(1, height);
            playerCords[1] = random.Next(1, width);
            playingField[playerCords[0], playerCords[1]] = pixel;
            SetFood();
            PrintFrame();

        }
        static void FrameUpdate()
        {

        }
        static void SetFood()
        {
            FoodCords[0] = random.Next(1, height);
            FoodCords[1] = random.Next(1, width);
            playingField[FoodCords[0], FoodCords[1]] = food;
        }
        static void PrintFrame()
        {
            for(int i = 0; i < height; i++)
            {
                line = "";
                for(int j = 0; j < width; j++)
                {
                    line += playingField[i, j];
                }
                Console.WriteLine(line);
            }
        }

    }
}
