using HoshBesh;
using HoshBesh.Floors;

namespace HoshBesh.Floors
{
    internal abstract class BaseFloor
    {
        protected StoryNode? CurrentNode;
        
        public void Start()
        {
            while (CurrentNode != null)
            {
                Console.Clear();
                Console.WriteLine("\n" + CurrentNode.Description);

                if (CurrentNode.Options.Count > 0)
                {
                    // Show options
                    for (int i = 0; i < CurrentNode.Options.Count; i++)
                    {
                        var optionKey = CurrentNode.Options.Keys.ElementAt(i);
                        var optionDescription = CurrentNode.OptionsDescriptions?[i] ?? optionKey;
                        Console.WriteLine($" {optionDescription}");
                    }

                    Console.Write("\nYour choice: ");
                    string playerChoice = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

                    bool matched = false;

                    // Check keywords of options
                    foreach (var option in CurrentNode.Options)
                    {
                        // If the text entered by the user contains the option keyword, it matches
                        if (playerChoice.Contains(option.Key.ToLower()))
                        {
                            CurrentNode = option.Value;
                            matched = true;
                            break; //Break the loop when you find the matching option
                        }
                    }

                    if (!matched)
                    {
                        if (playerChoice.Contains("exit")){ CurrentNode = null; }
                        else { Console.WriteLine("\n>> Invalid choice. Try again."); };
                       
                    }
                }
                else
                {
                    Console.WriteLine("\n>> No more options available. ");
                    CurrentNode = null;
                }
            }

            Console.WriteLine("\n>> The story has ended. Thank you for playing!");
        }

        protected abstract StoryNode BuildStory();
    }
}
