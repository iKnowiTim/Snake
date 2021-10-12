using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGameDemo
{
    public static class ManagerColors
    {
        static Colors Color = Colors.Standard;
        static readonly ConsoleColor[] consoleForegroundColors =
        {
            ConsoleColor.White,
            ConsoleColor.Green,
            ConsoleColor.Red
        };


        public static void SetColor(int selectedColor)
        {
            Color = (Colors)selectedColor;
        }

        public static ConsoleColor ColorForegroundGame
        {
            get
            {
                return consoleForegroundColors[(int)Color];
            }            
        }
        public static ConsoleColor ColorBackgroundGame()
        {
            if (Color == Colors.Standard)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (Color == Colors.Green)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (Color == Colors.Red)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            return Console.BackgroundColor;
        }

        public static ConsoleColor SelectedColorForegroundGame()
        {
            if (Color == Colors.Standard)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (Color == Colors.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (Color == Colors.Red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            return Console.ForegroundColor;
        }
        public static ConsoleColor SelectedColorBackgroundGame()
        {
            if (Color == Colors.Standard)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (Color == Colors.Green)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            else if (Color == Colors.Red)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            return Console.BackgroundColor;
        }

        public static void SetBackgroundAndForegroundConsole()
        {
            Console.ForegroundColor = ColorForegroundGame;
            Console.BackgroundColor = ColorBackgroundGame();
        }
    }
}
