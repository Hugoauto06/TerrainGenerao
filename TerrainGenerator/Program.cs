using System;

namespace TerrainGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize
            Player player1 = new Player(5, 5, 100);

            bool done = false;
            char InputCharacter = 'w';

            Console.SetWindowSize(160, 40);
            Console.CursorVisible = false;

            // Generator
            GenerateTerrain terrain = new GenerateTerrain();
            terrain.CreateTerrain();

            // inputs and Drawing Player

            while (!done) // Game Loop
            {
                // Juegologo
                Math.Clamp(player1.X, 1, Console.WindowWidth - 1);
                Math.Clamp(player1.Y, 1, Console.WindowHeight - 1);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(player1.X, player1.Y + 1); Console.Write(' '); 
                Console.SetCursorPosition(player1.X, player1.Y - 1); Console.Write(' '); 
                Console.SetCursorPosition(player1.X + 1, player1.Y); Console.Write(' '); 
                Console.SetCursorPosition(player1.X - 1, player1.Y); Console.Write(' '); 

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(player1.X, player1.Y); Console.Write("@");

                InputCharacter = Console.ReadKey(true).KeyChar;

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

                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth-8, Console.WindowHeight-2); Console.Write(player1.HP);
            }
        }
    }
}
