using System.Collections.Generic;
using The_HoshBesh.Classes;

namespace The_HoshBesh.Classes

{
    internal class Floor5 : BaseFloor
    {
        public Floor5()
        {
            CurrentNode = BuildStory();
        }

        protected override StoryNode BuildStory()
        {
            var floor5 = new StoryNode("You enter a dark and cold dungeon. Before you lies the Cocoa Guardian.");

            StoryNode cocoaChallenge = new StoryNode(
                 "The Cocoa Guardian speaks:\n" +
                 "\"Welcome, brave adventurer! I am the Cocoa Guardian. To proceed, you must play my game.\"\n" +
                 "Three doors stand before you: " +
                 "Left Door, Middle Door, and Right Door.\n" +
                 "You will choose one of these doors. Behind one of the doors is chocolate reward, while behind the other two is rotten cocoa. \n" +
                 "Choose wisely!\n");

            var pickLeft = new StoryNode("You have chosen the Left Door. I reveal that the Middle Door leads to rotten cocoa. Will you switch to the Right Door or stay?");
            var pickMiddle = new StoryNode("You have chosen the Middle Door. I reveal that the Right Door leads to rotten cocoa. Will you switch to the Left Door or stay?");
            var pickRight = new StoryNode("You have chosen the Right Door. I reveal that the Middle Door leads to rotten cocoa. Will you switch to the Left Door or stay?");

            var win = new StoryNode("Congratulations! You found the chocolate reward and may proceed to the next floor.");
            var lose = new StoryNode("Oh no! You chose rotten cocoa. You are trapped here forever.");

            floor5.Options.Add("approach guardian", cocoaChallenge);

            cocoaChallenge.Options.Add("choose left", pickLeft);
            cocoaChallenge.Options.Add("choose middle", pickMiddle);
            cocoaChallenge.Options.Add("choose right", pickRight);

            // Link nodes for Left Door
            pickLeft.Options.Add("switch", lose);
            pickLeft.Options.Add("stay", win);

            // Link nodes for Middle Door
            pickMiddle.Options.Add("switch", win);
            pickMiddle.Options.Add("stay", lose);

            // Link nodes for Right Door
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
