using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGameDemo.Snake
{
    class Map
    {
        public int Width { get; }
        public int Height { get; }
        char symbol;

        public Map(int width, int height, char symbol)
        {
            Width = width;
            Height = height;
            this.symbol = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            ManagerColors.SetBackgroundAndForegroundConsole();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || j == 0 || i == Height - 1 || j == Width - 1)
                    {
                        Console.Write(symbol);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }            
        }
    }
}
