using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MenuGameDemo.Snake;
using System.Threading.Tasks;
using static System.Console;

namespace MenuGameDemo
{
    class Game
    {
        public void Start()
        {
            RunMenu();
        }        

        public void RunMenu()
        {            
            Console.CursorVisible = false;
            string titleGame = @"
 █████╗ ██╗     ███████╗██╗  ██╗███████╗██╗   ██╗
██╔══██╗██║     ██╔════╝╚██╗██╔╝██╔════╝╚██╗ ██╔╝
███████║██║     █████╗   ╚███╔╝ █████╗   ╚████╔╝ 
██╔══██║██║     ██╔══╝   ██╔██╗ ██╔══╝    ╚██╔╝  
██║  ██║███████╗███████╗██╔╝ ██╗███████╗   ██║   
╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝   
                                                 
";
            string[] options = { "Play", "Informations", "OptionsColor", "Exit" };
            Menu mainMenu = new Menu(titleGame, options);

            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Information();
                    break;
                case 2:
                    Options();
                    break;
                case 3:
                    Exit();
                    break;
                default:
                    break;
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void Options()
        {
            string[] options = {"Standard", "Green", "Red" };
            string title = "Choose a Color";

            Menu menuOptions = new Menu(title, options);
            int selectedIndexColor = menuOptions.Run();

            ManagerColors.SetColor(selectedIndexColor);
            ManagerColors.SetBackgroundAndForegroundConsole();
            RunMenu();
        }

        public void Information()
        {
            Clear();
            Console.WriteLine(@"
 ██████╗          ██████╗ 
██╔═══██╗        ██╔═══██╗
██║   ██║        ██║   ██║
██║▄▄ ██║        ██║▄▄ ██║
╚██████╔╝███████╗╚██████╔╝
 ╚══▀▀═╝ ╚══════╝ ╚══▀▀═╝ 
                          

Support a poor company with the Russian ruble");
            Console.WriteLine("Press the Enter");
            ReadKey(true);
            Exit();
        }

        public void StartGame()
        {
            Console.Clear();
            SnakeGame snake = new SnakeGame();
            snake.Start();
        }
    }
}
