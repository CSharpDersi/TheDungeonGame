using HoshBesh;
using HoshBesh.Classes;

namespace HoshBesh.Classes
{
    internal class Floor1 : BaseFloor
    {
        public Floor1()
        {
            CurrentNode = BuildStory();
        }

        protected override StoryNode BuildStory()
        {
            StoryNode start = new StoryNode("Dragon eggs found years ago were revived by scientists. However, some mistakes that occurred during the experiments caused mutations in the dragons." +
                "\nThey could now think and talk like humans. They were also, for some unknown reason, addicted to HoshBesh biscuits." +
                "\nThese addictions were not a big problem for people at first. The number of them were little and they were still young. These reasons made them seem harmless." +
                "\nAs the years went by, problems began to arise. The dragons grew and multiplied." +
                "\nBecause of their addiction to HoshBesh, they started to prevent people from consuming it and said that only they could consume it." +
                "\nOver time, they were not satisfied with this and also banned the consumption of the substances used in the production of HoshBesh." +
                "\nIn this period when a new ban is added every day, a group of people decided to put an end to this situation. You joined these people and started a rebellion." +
                "\nBut you were not successful. Many of you lost your lives, and the rest of you were thrown into a dungeon ruled by dragons addicted to five different tastes of HoshBesh." +
                "\nAs the years passed, you started to think that you would never be able to get out of this dungeon again." +
                "\nHowever, this year the dragons that ruled the dungeon were replaced by new dragons." +
                "\nThese dragons gave you a chance to escape." +
                "\nThey said'If you are confident, accept the challenge and try to escape. But if you fail, that will be the end of you.'." +
                "\nWhat will you do?\n")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "Stay in the dungeon",
                    "Try to escape"
                }
            };
            StoryNode f1_stayInDungeon = new StoryNode("You were not brave enough and never tried to escape. You spent the rest of your life in the dungeon.")
            { RequiresInput = false };

            StoryNode f1_riddle1 = new StoryNode("You gathered your courage and decided to try to escape. After dinner was served, a baby dragon appeared." +
                            "\nYou said that you accepted the challenge they presented. The baby dragon laughed." +
                            "\n'Then you must solve my riddle first.'" +
                            "\n'How many moves does it take to put a crocodile in the refrigerator?'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "2 moves",
                    "3 moves"
                }
            };
            StoryNode f1_riddle1Correct = new StoryNode("The baby dragon grumbled." +
             "\n'Correct. First move, you open the refrigerator door. Second move, you put the crocodile inside. Third move, you close the refrigerator door.'" +
             "\nYou got out of cellar. Now you must decide where to go. You saw something at the end of the corridor.");

            StoryNode f1_riddle2 = new StoryNode("The baby dragon burst into laughter." +
                            "\n'Wrong. First move, you open the refrigerator door. Second move, you put the crocodile inside. Third move, you close the refrigerator door.'" +
                            "\n'I will give you one last chance. But if you get it wrong, I will lead you through the dark corridors and leave you in the depths of the dungeon where you can never escape.'" +
                            "\n'Here is the riddle:'" +
                            "\n'How many moves does it take to put an elephant in the refrigerator?'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "4 moves",
                    "3 moves"
                }
            };
            StoryNode f1_riddle2Incorrect = new StoryNode("'You fell into my trap and forgot the crocodile. Now I will take you to the depths of the dungeon.'" +
            "The baby dragon grabbed your arm and started running. When you came an area shrouded in darkness, it leave you there and ran off. " +
            "Even though you can not see, you may escape if you retrace your steps.");

            StoryNode f1_riddle2Correct = new StoryNode("You didn’t forget the crocodile. I’ll let you out of the cellar. Let’s see if you can escape the dungeon.");

            StoryNode f1_path = new StoryNode("Two trees appear in front of you: a palm tree on the right and a sycamore tree on the left.")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "Go right",
                    "Go left"
                }
            };

            StoryNode f1_rightPath = new StoryNode("You walked on the right path. There was someone at the of the way.");

            StoryNode f1_leftPath = new StoryNode("You lost in the dungeon and found yourself somewhere shrouded in darkness.");


            StoryNode f1_retracePath = new StoryNode("This was the path you took:" +
                "\nFirst, go right, then up to stairs, and then in order: right, left, right and finally right again." +
                "\nYou need to retrace your steps. Which path will you take?")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "Left-left-right-left-down the stairs-left",
                    "Right-up to stairs-right-left-right-right"
                }
            };

            StoryNode f1_correctRetracePath = new StoryNode("You successfully retrace your steps.");
            StoryNode f1_cryingSound = new StoryNode("You had to do the reverse of the path you took. You got even more lost. " +
                           "\nAs you were wondering what to do, you suddenly heard someone crying, unsure of who it is." +
                           "\nWill you follow the sound?")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "Follow the sound",
                    "Do not follow the sound"
                }
            };
            StoryNode f1_cocoDragon = new StoryNode("You saw the coconut dragon at the end of the way. The coconut dragon was crying. It wiped its tears when it saw you and greeted you." +
                           "\n'Hello. I am Coco, the coconut dragon. It is brave of you to try to escape from the dungeon. Unfortunately, I am not as brave as you. I do not want to stop people from escaping, but I am too afraid to oppose the others.'" +
                           "\nYou realized the coconut dragon does not want to harm people. If you could encourage it, you might save both yourself and the dragon. " +
                           "\nYou tried to recall a quote about courage from a great leader. If you can get it right, you might inspire the dragon. " +
                           "\nWhich one was a great leader?")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "Nelson Mandela",
                    "Confucius"
                }
            };
            StoryNode f1_inspireDragon = new StoryNode("You turned to the coconut dragon and said, " +
                          "\n'A brave man is not one who does not feel afraid, but one who conquers that fear, said Nelson Mandela. You can overcome your fear too.'" +
                          "\nYour words touched the dragon’s heart. Its eyes filled with hope, and it said " +
                          "\n'You have given me courage. Here is the key, you can take it. May your courage serve you well against the other dragons. Do not forget me!'");

            StoryNode f1_chickenRiddle = new StoryNode("You turned to the coconut dragon and said,'If you know something is right and do not stand up for it, you are a coward, said Confucius.'\nHearing this, the dragon began crying again.'I know I am a coward; that is why I cannot leave. At least you can escape if you can answer my question.'\n'Which creature is known for its cowardice?'")
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "Chicken",
                    "Dragon"
                }
            };
            StoryNode f1_correctAnswer = new StoryNode("'Correct! The chicken is known for its cowardice. Here is the key. Do not forget me!'"); ;
            StoryNode f1_wrongAnswer = new StoryNode("The dragon keeps crying. " +
                    "\n'It is natural to think that after seeing me. Here is the key, you can take it. Do not forget me!'");

            StoryNode f1_escapeFloor2 = new StoryNode("You have escaped to the next floor.");

            StoryNode f1_gameOver = new StoryNode("You heard someone crying but ignored the sound. " +
                "\nDue to darkness you slowly lost your sense of direction and were unable to escape the depths of the dungeon.")
            { RequiresInput = false };

            start.Options.Add("stay", f1_stayInDungeon);
            start.Options.Add("escape", f1_riddle1);

            f1_stayInDungeon.Options.Add("exit", null);

            f1_riddle1.Options.Add("2", f1_riddle2);
            f1_riddle1.Options.Add("3", f1_riddle1Correct);

            f1_riddle1Correct.Options.Add("look", f1_path);

            f1_path.Options.Add("right", f1_rightPath);
            f1_path.Options.Add("left", f1_leftPath);

            f1_rightPath.Options.Add("keep going", f1_cocoDragon);
            f1_leftPath.Options.Add("go back", f1_retracePath);

            f1_riddle2.Options.Add("4", f1_riddle2Correct);
            f1_riddle2.Options.Add("3", f1_riddle2Incorrect);

            f1_riddle2Correct.Options.Add("look", f1_path);
            f1_riddle2Incorrect.Options.Add("go back", f1_retracePath);

            f1_retracePath.Options.Add("down", f1_correctRetracePath);
            f1_retracePath.Options.Add("up", f1_cryingSound);

            f1_correctRetracePath.Options.Add("keep going", f1_cocoDragon);

            f1_cryingSound.Options.Add("follow", f1_cocoDragon);
            f1_cryingSound.Options.Add("do not follow", f1_gameOver);

            f1_gameOver.Options.Add("exit", null);

            f1_cocoDragon.Options.Add("nelson mandela", f1_inspireDragon);
            f1_cocoDragon.Options.Add("confucius", f1_chickenRiddle);

            f1_inspireDragon.Options.Add("take the key", f1_escapeFloor2);

            f1_chickenRiddle.Options.Add("chicken", f1_correctAnswer);
            f1_chickenRiddle.Options.Add("dragon", f1_wrongAnswer);

            f1_correctAnswer.Options.Add("take the key", f1_escapeFloor2);
            f1_wrongAnswer.Options.Add("take the key", f1_escapeFloor2);

            f1_escapeFloor2.Options.Add("proceed", new Floor2().GetStartNode());

            return start;
        }

        public StoryNode GetStartNode()
        {
            return CurrentNode;
        }
    }
}