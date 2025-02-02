﻿using HoshBesh;
using HoshBesh.Floors;

namespace HoshBesh.Floors
{
    internal class Floor3 : BaseFloor
    {
        public Floor3()
        {
            CurrentNode = BuildStory();
        }

        protected override StoryNode BuildStory()
        {
            StoryNode floor3 = new StoryNode("In the darkness of the dungeon, you hear Fresilia's voice:\n\n'You must choose a path to dispel this darkness. But beware! Your choice will lead you to another adventure. Two symbols appear on the walls: a torch and a full moon. Which one do you choose?'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "torch",
                    "moon"
                }
            };

            StoryNode torchPath = new StoryNode("You chose the torch symbol, the darkness brightens, and the ground becomes visible again. You notice the ceiling moving rapidly, and spiked vines begin to hang down from above. Fresilia's voice echoes:\n\n'You have chosen a brave light, but to reap the rewards of your courage, you must show your wit and agility. The ground is too fragile and deceptive to support you. But look up! Can you see the glow of the golden berry?'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "climb for strawberry",
                    "search for safe tiles"
                }
            };

            StoryNode moonPath = new StoryNode("You choose the full moon. A tunnel appears, leading you out of the forest. At the end of the tunnel, a darkness looms, following close behind you.")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "confront fresilia"
                }
            };

            StoryNode goldenStrawberry = new StoryNode("You lunge toward the berry, sliding through the spiked vines. You manage to reach the berry and grab hold of it. Fresilia laughs:\n\n'Wise choice! The golden berry has saved you, but this journey is far from over.'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "let's continue"
                }
            };

            StoryNode riskyPath = new StoryNode("Fresilia speaks in a cunning tone:\n\n'You failed to notice the glow of the golden berry and chose your own path. Some tiles on the ground may keep you safe, but others will drag you into the deep darkness. To find out which ones are safe, you must solve the riddle.'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "solve riddle"
                }
            };

            StoryNode chaseOrFollow = new StoryNode("The figure in the darkness takes a step toward you, becoming slightly clearer. A towering, fearsome dragon emitting pink flames stands before you. Fresilia's voice echoes:\n\n'You must decide: Will you flee or follow? Your choice will determine your fate.'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "escape",
                    "follow"
                }
            };

            StoryNode escape = new StoryNode("You try to escape, but the dragon catches you and takes you to the next dungeon. Fresilia's voice echoes:\n\n'Escape was never an option. Now, a greater challenge awaits you!'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {

                    "oh i am sorry, lets continue"
                }
            };

            StoryNode follow = new StoryNode("You follow the dragon. Fresilia's voice echoes:\n\n'Your courage has carried you forward, but this path leads to another friend's dungeon. Are you ready for a new challenge?'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "i am ready",

                }
            };

            StoryNode emptyRoom = new StoryNode("You suddenly find yourself in an empty room. At first, the room seems calm, but soon strawberry juice begins to seep from the corners. Fresilia’s voice echoes:\n 'Ah, your courage and intelligence have brought you here. But only wisdom can save you in this room. The strawberry juice is rising, and soon this room will be completely filled. There is a window on the floor. To open it, you must solve the riddle!'\n Riddle: I am both a guide and a tester in software design.\n*My first principle demands that a class should have only one responsibility.\n*My second principle insists that code should be closed for modification but open for extension.\n*My third principle states that subclasses should be substitutable for their base classes.\n*My fourth principle advises that dependencies should rely on abstractions, not on details.\nCode that follows these principles, no matter how complex, is always readable and easy to maintain.\nWhat is the name of the principles that guide me?")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "solid principles",
                    "grasp principles"
                }
            };

            StoryNode correctAnswer = new StoryNode("The window suddenly opens. The strawberry juice rapidly recedes, and Fresilia’s voice echoes:\n\n'A wise mind can illuminate even the darkest dungeons. But this is not the end of your journey. Prepare yourself; you are about to go deeper!'\n She extends a key to you")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "take the key",

                }
            };

            StoryNode wrongAnswer = new StoryNode("Fresilia lets out a quiet chuckle:\n\n'Ah, you came so close, but wisdom has abandoned you. The strawberry juice keeps rising. Do you have one more chance?'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "retry",
                    "fail"
                }
            };

            StoryNode failAnswer = new StoryNode("The room fills entirely with strawberry juice, and the glass shatters under the pressure. Fresilia’s voice echoes, tinged with a hint of disappointment:\n\n'Your knowledge was not enough to save you, and you failed to conquer my dungeon.'\nWith a sudden surge of energy, she casts you out, and you find yourself hurled into the unknown...")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                "i am not afraid of the unknown"
                }
            };

            StoryNode floor4 = new StoryNode("You have escaped to the next floor.");

            floor3.Options.Add("torch", torchPath);
            floor3.Options.Add("moon", moonPath);

            torchPath.Options.Add("climb", goldenStrawberry);
            torchPath.Options.Add("search", riskyPath);
            moonPath.Options.Add("confront", chaseOrFollow);

            chaseOrFollow.Options.Add("escape", escape);
            chaseOrFollow.Options.Add("follow", follow);

            goldenStrawberry.Options.Add("continue", emptyRoom);
            riskyPath.Options.Add("solve", emptyRoom);

            emptyRoom.Options.Add("solid", correctAnswer);
            emptyRoom.Options.Add("grasp", wrongAnswer);

            wrongAnswer.Options.Add("retry", emptyRoom);
            wrongAnswer.Options.Add("fail", failAnswer);

            follow.Options.Add("ready", floor4);
            escape.Options.Add("sorry", floor4);

            correctAnswer.Options.Add("take", floor4);
            failAnswer.Options.Add("i am not afraid of the unknown", floor4);

            floor4.Options.Add("proceed", new Floor4().GetStartNode());
            
            return floor3;
        }

        public StoryNode GetStartNode()
        {
            return CurrentNode!;
        }
    }
}
