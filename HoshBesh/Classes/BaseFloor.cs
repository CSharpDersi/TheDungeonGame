using HoshBesh;
using HoshBesh.Classes;
using System.Linq;

namespace HoshBesh.Classes
{
    internal abstract class BaseFloor
    {
        protected StoryNode CurrentNode;

        public void Start()
        {
            while (CurrentNode != null)
            {
                Console.Clear();
                Console.WriteLine("\n" + CurrentNode.Description);

                if (CurrentNode.Options.Count > 0)
                {
                    // Seçenekleri göster
                    for (int i = 0; i < CurrentNode.Options.Count; i++)
                    {
                        var optionKey = CurrentNode.Options.Keys.ElementAt(i);
                        var optionDescription = CurrentNode.OptionsDescriptions?[i] ?? optionKey;
                        Console.WriteLine($" {optionDescription}");
                    }

                    Console.Write("\nYour choice: ");
                    string playerChoice = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

                    bool matched = false;

                    // Seçeneklerin anahtar kelimelerini kontrol et
                    foreach (var option in CurrentNode.Options)
                    {
                        // Eğer kullanıcının girdiği metin, seçenek anahtar kelimesini içeriyorsa, eşleşir
                        if (playerChoice.Contains(option.Key.ToLower()))
                        {
                            CurrentNode = option.Value;
                            matched = true;
                            break; // Eşleşen seçeneği bulduğunda döngüyü kır
                        }
                    }

                    if (!matched)
                    {
                        Console.WriteLine("\n>> Invalid choice. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("\n>> No more options available. The game will now end.");
                    CurrentNode = null;
                }
            }

            Console.WriteLine("\n>> The story has ended. Thank you for playing!");
        }

        protected abstract StoryNode BuildStory();
    }
}
