using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGameDemo.Snake
{
    class Snake
    {
        List<Position> points;
        ConsoleKeyInfo keyInfo;
        int Score { get; set; }

        public Snake()
        {
            keyInfo = new ConsoleKeyInfo(' ', ConsoleKey.RightArrow, false, false, false);
            points = new List<Position>();
        }

        

        public void Draw()
        {
            foreach (var item in points)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write("@");
            }                         
            

        }        

        public void AcceptInput()
        {
            if (Console.KeyAvailable)

            keyInfo = Console.ReadKey(true);            

            if (points.Count == 0)
            {
                Position currentPos = new Position() { X = 5, Y = 5 };
                points.Add(currentPos);                

                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        currentPos.X++;
                        break;
                    case ConsoleKey.LeftArrow:
                        currentPos.X--;
                        break;
                    case ConsoleKey.UpArrow:
                        currentPos.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        currentPos.Y++;
                        break;                        
                }
                
                points.Add(currentPos);
                Position position = points.First();
                points.Remove(position);                
            }
            else
            {
                Position currentPos = points.Last();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        currentPos.X++;
                        break;
                    case ConsoleKey.LeftArrow:
                        currentPos.X--;
                        break;
                    case ConsoleKey.UpArrow:
                        currentPos.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        currentPos.Y++;
                        break;
                }

                points.Add(currentPos);
                Position position = points.First();
                points.Remove(position);
                Console.SetCursorPosition(position.X, position.Y);
                Console.Write(" ");
            }

            
        }

        public void Eat(FoodPeace foodPeace)
        {
            Position currentPos = points.Last();
            if (currentPos.X == foodPeace.position.X && currentPos.Y == foodPeace.position.Y)
            {
                points.Add(currentPos);
                foodPeace.AmountFood();
                Score += 100;
            }
            
        }

        public void CheckCollision(Map map)
        {
            Position tail = points.Last();

            if (tail.X == 1 || tail.Y == 1 || tail.X == map.Width - 1 || tail.Y == map.Height - 1)
            {
                Console.Clear();
                Console.SetCursorPosition(map.Width / 2, map.Height / 2);
                Console.WriteLine($"You lose. Your Score: {Score}. Press the Enter.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.SetCursorPosition(0, map.Height);
            Console.WriteLine($"Score: {Score}");
        }
    }
}
