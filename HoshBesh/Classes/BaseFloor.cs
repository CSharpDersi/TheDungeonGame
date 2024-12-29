using System;
using System.Collections.Generic;

namespace The_HoshBesh.Classes
{
    internal abstract class BaseFloor
    {
        protected StoryNode CurrentNode;

        public void Start()
        {
            while (CurrentNode != null)
            {
                Console.Clear();
                Console.WriteLine("\\n" + CurrentNode.Description);

                if (CurrentNode.Options.Count > 0)
                {
                    foreach (var option in CurrentNode.Options)
                    {
                        Console.WriteLine($" - {option.Key}");
                    }

                    Console.Write("\\nYour choice: ");
                    string playerChoice = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

                    if (CurrentNode.Options.ContainsKey(playerChoice))
                    {
                        CurrentNode = CurrentNode.Options[playerChoice];
                    }
                    else
                    {
                        Console.WriteLine("\\n>> Invalid choice. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("\\n>> No more options available. The game will now end.");
                    CurrentNode = null;
                }
            }

            Console.WriteLine("\\n>> The story has ended. Thank you for playing!");
        }

        protected abstract StoryNode BuildStory();
    }
}
