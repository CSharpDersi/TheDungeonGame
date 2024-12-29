using HoshBesh;
using System;
using The_HoshBesh.Classes;

namespace The_HoshBesh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            bool isGameRunning = true;

            while (isGameRunning)
            {
                menu.DisplayOptions();
                string playerInput = menu.GetPlayerInput();

                switch (playerInput)
                {
                    case "start":
                        Console.WriteLine("\\n>> The game is starting...\\n");
                        Floor1 floor1 = new Floor1();
                        floor1.Start();
                        break;

                    case "exit":
                        Console.WriteLine("\\n>> Exiting the game. Goodbye!\\n");
                        isGameRunning = false;
                        break;

                    default:
                        Console.WriteLine("\\n>> Invalid option. Please try again.\\n");
                        break;
                }
            }
        }
    }
}
