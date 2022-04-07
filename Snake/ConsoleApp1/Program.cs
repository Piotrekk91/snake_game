using System;


namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool exit = false;
            double frameRate = 1000 / 5.0;
            DateTime lastDate = DateTime.Now;
            Meal meal = new Meal();
            Snake snake = new Snake();


            //Game Loop
            while (!exit)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    switch (input.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;    
                            break;
                        case ConsoleKey.DownArrow:
                            snake.Direction = Direction.Down;
                            //move
                            break;
                        case ConsoleKey.UpArrow:
                            snake.Direction = Direction.Up;
                            //move
                            break;
                        case ConsoleKey.LeftArrow:
                            snake.Direction = Direction.Left;
                            //move
                            break;
                        case ConsoleKey.RightArrow:
                            snake.Direction = Direction.Right;
                            //move
                            break;


                    }


                }
                if((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    //Game Action
                    snake.Move();
                    
                    if(meal.CurrentPosition.X == snake.HeadPosition.X 
                        &&meal.CurrentPosition.Y == snake.HeadPosition.Y)
                    {
                        snake.EatMeal();
                        meal = new Meal();
                        frameRate /= 1.1;
                    }

                    if (snake.GameOver)
                    {
                        Console.Clear();
                        Console.WriteLine($"GAME OVER. YOUR SCORE:{snake.Length}");
                        exit = true;
                        Console.ReadLine();

                    }

                    lastDate = DateTime.Now;
                }
                
              

            }
            

        }
    }
}
