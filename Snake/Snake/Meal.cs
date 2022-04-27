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

        public void CreateMeal(List<Coordinate> snakeTail)
        {
            Random random = new Random();

            int x = random.Next(1, 20);
            int y = random.Next(1, 20);
            foreach(var tailUnit in snakeTail)
            {
                if(tailUnit.X == x && tailUnit.Y == y)
                {
                    CreateMeal(snakeTail);
                    return;
                }
            }
            CurrentPosition = new Coordinate(x, y);
            Draw();
        }
        public void Draw()
        {
            Console.SetCursorPosition(CurrentPosition.X,CurrentPosition.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("$");
            
        }
    }
}
