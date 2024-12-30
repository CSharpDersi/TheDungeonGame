using HoshBesh;
using HoshBesh.Classes;

namespace HoshBesh.Classes 
{
    internal class Floor5 : BaseFloor
    {
        public Floor5()
        {
            CurrentNode = BuildStory();
        }

        protected override StoryNode BuildStory()
        {
            StoryNode floor5 = new StoryNode(
                 "The Cocoa Guardian speaks:\n" +
                 "\"Welcome, brave adventurer! I am the Cocoa Guardian. To proceed, you must play my game.\"\n" +
                 "Three doors stand before you: " +
                 "Left Door, Middle Door, and Right Door.\n" +
                 "You will choose one of these doors. Behind one of the doors is chocolate reward, while behind the other two is rotten cocoa. \n" +
                 "Choose wisely!\n")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "- choose left",
                    "- choose middle",
                    "- choose right"
                }
            };

            StoryNode pickLeft = new StoryNode("You have chosen the Left Door. I reveal that the Middle Door leads to rotten cocoa. Will you switch to the Right Door or stay?")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "- switch",
                    "- stay"
                }
            };

            StoryNode pickMiddle = new StoryNode("You have chosen the Middle Door. I reveal that the Right Door leads to rotten cocoa. Will you switch to the Left Door or stay?")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "- switch",
                    "- stay"
                }
            };

            StoryNode pickRight = new StoryNode("You have chosen the Right Door. I reveal that the Middle Door leads to rotten cocoa. Will you switch to the Left Door or stay?")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "- switch",
                    "- stay"
                }
            };

            StoryNode win = new StoryNode("Congratulations! You found the chocolate reward and may proceed to the next floor.");
            StoryNode lose = new StoryNode("Oh no! You chose rotten cocoa. You are trapped here forever.");

            floor5.Options.Add("left", pickLeft);
            floor5.Options.Add("middle", pickMiddle);
            floor5.Options.Add("right", pickRight);

            pickLeft.Options.Add("switch", lose);
            pickLeft.Options.Add("stay", win);

            pickMiddle.Options.Add("switch", win);
            pickMiddle.Options.Add("stay", lose);

            pickRight.Options.Add("switch", win);
            pickRight.Options.Add("stay", lose);

            return floor5;
        }

        public StoryNode GetStartNode()
        {
            return CurrentNode;
        }
    }
}
