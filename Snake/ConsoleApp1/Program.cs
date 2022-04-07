using System;


namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            bool exit = false;
            double frameRate = 1000 / 5.0;
            DateTime lastDate = DateTime.Now;

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
                            //move
                            break;
                        case ConsoleKey.UpArrow:
                            //move
                            break;
                        case ConsoleKey.LeftArrow:
                            //move
                            break;
                        case ConsoleKey.RightArrow:
                            //move
                            break;


                    }


                }
                if((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    //Game Action

                    lastDate = DateTime.Now;
                }
                
              

            }
            

        }
    }
}
