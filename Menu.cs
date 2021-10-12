using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGameDemo
{
    public class Menu
    {
        string titleGame;
        string[] options;
        int selectedIndex;
        

        public Menu(string titleGame, string[] options)
        {
            selectedIndex = 0;
            this.titleGame = titleGame;
            this.options = options;
        }

        private void Display()
        {
            ManagerColors.SetBackgroundAndForegroundConsole();
            Console.WriteLine(titleGame);
            
            for (int i = 0; i < options.Length; i++)
            {
                if (selectedIndex == i)
                {
                    Console.ForegroundColor = ManagerColors.SelectedColorForegroundGame();
                    Console.BackgroundColor = ManagerColors.SelectedColorBackgroundGame();
                    Console.WriteLine($"*<<{options[i]}>>");
                } 
                else
                {
                    Console.ForegroundColor = ManagerColors.ColorForegroundGame;
                    Console.BackgroundColor = ManagerColors.ColorBackgroundGame();
                    Console.WriteLine($" <<{options[i]}>>");
                }                
            }
            Console.ResetColor();
        }

        public int Run()
        {
            while (true)
            {
                Console.Clear();
                Display();

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);

                if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;

                    if (selectedIndex == -1)
                    {
                        selectedIndex = options.Length - 1;
                    }
                }
                if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex > options.Length - 1)
                    {
                        selectedIndex = 0;
                    }
                }
                if (consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    return selectedIndex;
                }
            }            
        }

    }
}
