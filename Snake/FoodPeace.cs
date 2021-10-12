using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGameDemo.Snake
{
    class FoodPeace
    {
        internal Position position;
        Random rand;
        int amountFood = 0;

        public FoodPeace()
        {
            rand = new Random();            
        }        

        public void Draw(char symbol, Map map)
        {
            if (amountFood == 0)
            {
                position.X = rand.Next(2, map.Width - 2);
                position.Y = rand.Next(2, map.Height - 2);                
                amountFood++;
            }
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(symbol);
        }

        public void AmountFood()
        {
            amountFood--;
        }
    }
}
