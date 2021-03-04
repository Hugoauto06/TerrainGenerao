using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainGenerator
{
    public class GenerateTerrain{
        public void CreateTerrain()
        {
            Random r = new Random();
            int rInt = r.Next(0, 2);

            int WindowSize = Console.WindowWidth * Console.WindowHeight;

            for (int i = 0; i < WindowSize; i++)
            {
                rInt = r.Next(0, 2);
                if (rInt == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write('…');
                }
                if (rInt == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("¸");
                    
                }
                if (rInt == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("„");
                    
                }
            }
        }

        // Save each character on the screen (the map)
        public class Square
        {
            int POSITION { get; set; }
            char CHARACTER { get; set; }
            public Square(int position, char character)
            {
                POSITION = position;
                CHARACTER = character;
            }
        }
    }
}
