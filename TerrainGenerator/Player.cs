using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainGenerator
{
    public class Player{
        public int X { get; set; }
        public int Y { get; set; }
        public int HP { get; set; }

        public Player(int x, int y, int hp)
        {
            X = x;
            Y = y;
            HP = hp;
        }
    }
}
