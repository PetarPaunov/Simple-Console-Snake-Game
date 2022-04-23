using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodAsterisk : Food
    {
        private const char foodSymbol = '*';
        private const int points = 1;
        public FoodAsterisk(Wall wall, char foodSymbol, int points) 
            : base(wall, foodSymbol, points)
        {
        }
    }
}
