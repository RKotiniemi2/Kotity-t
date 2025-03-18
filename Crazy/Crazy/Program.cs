using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Crazy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;
            int width = 40;
            int height = 20;
            int score = 0;
            int speed = 100;
            bool gameOver = false;
            Random random = new Random();


            List<(int x, int y)> snake = new List<(int x, int y)>
            {
                (width / 2, height / 2)
            };
            (int x, int y) direction = (0, -1);

      
            (int x, int y) food = (random.Next(0, width), random.Next(0, height));

            while (!gameOver)
            {
          
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    direction = key switch
                    {
                        ConsoleKey.UpArrow => (0, -1),
                        ConsoleKey.DownArrow => (0, 1),
                        ConsoleKey.LeftArrow => (-1, 0),
                        ConsoleKey.RightArrow => (1, 0),
                        _ => direction
                    };
                }

        
                var head = (x: snake.First().x + direction.x, y: snake.First().y + direction.y);
                snake.Insert(0, head);

         
                if (head.x < 0 || head.x >= width || head.y < 0 || head.y >= height)
                {
                    gameOver = true;
                    break;
                }

                if (snake.Skip(1).Any(s => s == head))
                {
                    gameOver = true;
                    break;
                }

                if (head == food)
                {
                    score++;
                    food = (random.Next(0, width), random.Next(0, height));
                }
                else
                {
                    snake.RemoveAt(snake.Count - 1);
                }

      
                Console.Clear();
                Console.SetCursorPosition(food.x, food.y);
                Console.Write("■");

                foreach (var segment in snake)
                {
                    Console.SetCursorPosition(segment.x, segment.y);
                    Console.Write("■");
                }

                Console.SetCursorPosition(0, height);
                Console.Write($"Score: {score}");

                Thread.Sleep(speed);
            }

            Console.Clear();
            Console.SetCursorPosition(width / 2 - 5, height / 2);
            Console.Write("Game Over");
            Console.SetCursorPosition(width / 2 - 7, height / 2 + 1);
            Console.Write($"Final Score: {score}");
            Console.SetCursorPosition(width / 2 - 10, height / 2 + 2);
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
