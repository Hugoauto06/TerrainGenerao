using System;

namespace TerrainGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize
            Player player1 = new Player(5, 5);

            bool done = false;
            char InputCharacter = 'w';

            Console.SetWindowSize(160, 40);
            Console.CursorVisible = false;

            // Generator
            GenerateTerrain terrain = new GenerateTerrain();
            terrain.CreateTerrain();

            // inputs and Drawing Player

            while (!done)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.SetCursorPosition(player1.X, player1.Y); Console.Write("@");

                InputCharacter = Console.ReadKey().KeyChar;

                if (char.ToLower(InputCharacter) == 'w') 
                {
                    player1.Y -= 1;
                }

                if (char.ToLower(InputCharacter) == 'a')
                {
                    player1.X -= 1;
                }

                if (char.ToLower(InputCharacter) == 's')
                {
                    player1.Y += 1;
                }

                if (char.ToLower(InputCharacter) == 'd')
                {
                    player1.X += 1; 
                }

                Math.Clamp(player1.Y, 0, Console.WindowHeight);
            }
        }
    }
}
