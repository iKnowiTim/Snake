using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuGameDemo.Snake
{
    class SnakeGame
    {
        Map map;
        Snake snake;       
        FoodPeace FoodPeace;

        public SnakeGame()
        {
            map = new Map(60, 20, '#');
            snake = new Snake();
            FoodPeace = new FoodPeace();
        }

        public void Start()
        {
            map.Draw();
            while (true)
            {                
                snake.AcceptInput();                
                snake.Draw();
                Thread.Sleep(100);
                snake.CheckCollision(map);                
                FoodPeace.Draw('%', map);                
                snake.Eat(FoodPeace);                
            }            
        }
    }
}
