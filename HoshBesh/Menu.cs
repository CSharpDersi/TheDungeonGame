using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoshBesh
{
    internal class Menu
    {
        public void DisplayOptions()
        {
            Console.WriteLine("\n**");
            Console.WriteLine("     Welcome to The HoshBesh!");
            Console.WriteLine("");
            Console.WriteLine("Options:");
            Console.WriteLine(" - Type 'start' to begin the game.");
            Console.WriteLine(" - Type 'exit' to leave the game.");
            Console.WriteLine("\n");
        }

        public string GetPlayerInput()
        {
            Console.Write("Enter your choice: ");
            return Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        }
    }
}
