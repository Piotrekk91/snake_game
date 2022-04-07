using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Meal
    {
        public Coordinate CurrentPosition { get; set; }

        public Meal()
        {
            Random random = new Random();

            int x = random.Next(1, 20);
            int y = random.Next(1, 20);
            CurrentPosition = new Coordinate(x, y);
        }
        public void Draw()
        {
            Console.SetCursorPosition(CurrentPosition.X,CurrentPosition.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("$");
            
        }
    }
}
