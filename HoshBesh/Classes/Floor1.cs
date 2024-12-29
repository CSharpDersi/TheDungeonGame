using The_HoshBesh.Classes;

internal class Floor1 : BaseFloor
{
    public Floor1()
    {
        CurrentNode = BuildStory();
    }

    protected override StoryNode BuildStory()
    {
        StoryNode start = new StoryNode("You are in a dungeon. What will you do?");

        StoryNode stayInDungeon = new StoryNode("You weren't brave enough and never tried to escape. You spent the rest of your life in the dungeon.");

        StoryNode riddle2 = new StoryNode("You gathered your courage and decided to try to escape. After dinner was served, a baby dragon appeared.\nYou said that you accepted the challenge they presented.\nThe baby dragon laughed.'Then you must solve my riddle first.'\n'How many moves does it take to put a crocodile in the refrigerator?'");
        StoryNode riddle2Correct = new StoryNode("The baby dragon grumbled.'Correct. First move, you open the refrigerator door. Second move, you put the crocodile inside. Third move, you close the refrigerator door.'\nYou got out of cellar. Now you must decide where to go. You saw something at the end of the corridor.");

        StoryNode riddle3 = new StoryNode("The baby dragon burst into laughter.'Wrong. First move, you open the refrigerator door. Second move, you put the crocodile inside. Third move, you close the refrigerator door.'\n'I will give you one last chance. But if you get it wrong, I will lead you through the dark corridors and leave you in the depths of the dungeon where you can never escape.'\n'Here is the riddle:'\n'How many moves does it take to put an elephant in the refrigerator?'");
        StoryNode riddle3Incorrect = new StoryNode("'You fell into my trap and forgot the crocodile. Now I will take you to the depths of the dungeon.'\nThe baby dragon grabbed your arm and started running. When you came an area shrouded in darkness, it leave you there and ran off. Even though you can not see, you may escape if you retrace your steps.");
        StoryNode riddle3Correct = new StoryNode("You didn’t forget the crocodile. I’ll let you out of the cellar. Let’s see if you can escape the dungeon.");

        StoryNode path = new StoryNode("Two trees appear in front of you: a palm tree on the right and a sycamore tree on the left.");
        StoryNode rightPath = new StoryNode("You walked on the right path. There was someone at the of the way.");
        StoryNode leftPath = new StoryNode("You lost in the dungeon and found yourself somewhere shrouded in darkness.");

        StoryNode retracePath = new StoryNode("This was the path you took:\nFirst, go right, then up to stairs,and then in order: right,left,right and finally right again.\nYou need to retrace your steps. Which path will you take?");
        StoryNode correctRetracePath = new StoryNode("You succesfully retrace your steps.");
        StoryNode cryingSound = new StoryNode("You had to do the reverse of the path you took.You got even more lost. As you were wondering what to do, you suddenly heard someone crying, unsure of who it is.\nWill you follow the sound?");

        StoryNode cocoDragon = new StoryNode("You saw the coconut dragon at the end of the way. The coconut dragon was crying. It wiped its tears when it saw you and greeted you.\n'Hello. I am Coco, the coconut dragon. It is brave of you to try to escape from the dungeon. Unfortunately, I am not as brave as you. I do not want to stop people from escaping, but I am too afraid to oppose the others.'\nYou realized the coconut dragon do not want to harm people. If you could encourage it, you might save both yourself and the dragon. You tried to recall a quote about courage from a great leader. If you can get it right, you might inspire the dragon. Which one was a great leader?");
        StoryNode inspireDragon = new StoryNode("You turned to the coconut dragon and said, 'A brave man is not one who does not feel afraid, but one who conquers that fear, said Nelson Mandela. You can overcome your fear too.'\nYour words touched the dragon’s heart. Its eyes filled with hope, and it said 'You have given me courage. Here is the key, you can take it. May your courage serve you well against the other dragons. Do not forget me!'");

        StoryNode chickenRiddle = new StoryNode("You turned to the coconut dragon and said,'If you know something is right and do not stand up for it, you are a coward, said Confucius.'\nHearing this, the dragon began crying again.'I know I am a coward; that is why I can not leave. At least you can escape if you can answer my question.'\n'Which creature is known for its cowardice?'");
        StoryNode correctAnswer = new StoryNode("'Correct! The chicken is known for its cowardice. Here is the key. Do not forget me!'");
        StoryNode wrongAnswer = new StoryNode("The dragon keeps crying. 'It is natural to think that after seeing me. Here is the key, you can take it. Do  ot forget me!'");

        StoryNode escapeFloor2 = new StoryNode("You have escaped to the next floor.");
        StoryNode gameOver = new StoryNode("You heard someone crying but ignored the sound.\nDue to darkness you slowly lost your sense of direction and were unable to escape the depths of the dungeon. ");

        start.Options.Add("stay in the dungeon", stayInDungeon);
        start.Options.Add("try to escape", riddle2);

        stayInDungeon.Options.Add("exit", null);

        riddle2.Options.Add("2 moves", riddle3);
        riddle2.Options.Add("3 moves", riddle2Correct);

        riddle2Correct.Options.Add("have a look", path);

        path.Options.Add("go right", rightPath);
        path.Options.Add("go left", leftPath);

        rightPath.Options.Add("keep going", cocoDragon);
        leftPath.Options.Add("try to go back", retracePath);

        riddle3.Options.Add("4 moves", riddle3Correct);
        riddle3.Options.Add("3 moves", riddle3Incorrect);

        riddle3Correct.Options.Add("have a look", path);
        riddle3Incorrect.Options.Add("try to go back", retracePath);

        retracePath.Options.Add("left-left-right-left-down the stairs-left", correctRetracePath);
        retracePath.Options.Add("right-up to stairs-right-left-right-right", cryingSound);

        correctRetracePath.Options.Add("keep going", cocoDragon);

        cryingSound.Options.Add("follow the sound", cocoDragon);
        cryingSound.Options.Add("do not follow the sound", gameOver);

        gameOver.Options.Add("exit", null);

        cocoDragon.Options.Add("nelson mandela", inspireDragon);
        cocoDragon.Options.Add("confucius", chickenRiddle);

        inspireDragon.Options.Add("take the key", escapeFloor2);

        chickenRiddle.Options.Add("chicken", correctAnswer);
        chickenRiddle.Options.Add("dragon", wrongAnswer);

        correctAnswer.Options.Add("take the key", escapeFloor2);
        wrongAnswer.Options.Add("take the key", escapeFloor2);

        escapeFloor2.Options.Add("proceed", new Floor2().GetStartNode());

        return start;
    }

    public StoryNode GetStartNode()
    {
        return CurrentNode;
    }
}