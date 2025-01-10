using HoshBesh;
using HoshBesh.Classes;

namespace HoshBesh.Classes
{
    internal class Floor4 : BaseFloor
    {
        public Floor4()
        {
            CurrentNode = BuildStory();
        }

        protected override StoryNode BuildStory()
        {
            StoryNode floor4 = new StoryNode(
               "You enter the Nutty Lair, a cave filled with the aroma of roasted hazelnuts. Suddenly, a booming voice echoes: 'Who dares enter my domain without cracking a joke first?' " +
               "\nScrat, a nut-loving squirrel, scurries up and whispers: 'We need to outwit the Hazelnut Dragon! Let's play along.'"
           );

            StoryNode firstQuestion = new StoryNode(
                "The Hazelnut Dragon appears, its eyes glinting mischievously. 'What is the world's largest producer of hazelnuts, accounting for 64% of total production?'"
            )
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "A) Italy",
                    "B) Turkey"
                }
            };

            StoryNode correctAnswer1 = new StoryNode(
                "The dragon nods approvingly. 'Impressive! You seem to know your nuts. Let’s move on to the next question.'"
            );

            StoryNode wrongAnswer1 = new StoryNode(
                "The dragon groans. 'Wrong! That was nutty nonsense. Try harder if you value your shell!'"
            );

            StoryNode secondQuestion = new StoryNode(
                "The dragon smirks. 'Which movie series features the squirrel who keeps chasing a hazelnut?'"
            )
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "A) Ice Age",
                    "B) Shrek"
                }
            };

            StoryNode correctAnswer2 = new StoryNode(
                "The dragon laughs heartily. 'You’re on a roll! Scrat nods approvingly.'"
            );

            StoryNode wrongAnswer2 = new StoryNode(
                "The dragon snorts. 'That’s the best you can do? You’d better shape up.'"
            );

            StoryNode thirdQuestion = new StoryNode(
                "The dragon leans forward. 'Which beverage often includes hazelnut syrup as a flavor?'"
            )
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "A) Coffee",
                    "B) Tea"
                }
            };

            StoryNode correctAnswer3 = new StoryNode(
                "The dragon nods. 'Ah, coffee and hazelnuts—a classic pair! Let’s move on.'"
            );

            StoryNode wrongAnswer3 = new StoryNode(
                "The dragon frowns. 'Nope! That’s not it. Let’s crack another one.'"
            );

            StoryNode fourthQuestion = new StoryNode(
                "The dragon swirls its tail. 'Which vitamin is particularly abundant in hazelnuts?'"
            )
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "A) Vitamin E",
                    "B) Vitamin C"
                }
            };

            StoryNode correctAnswer4 = new StoryNode(
                "The dragon claps its claws. 'Correct! You truly know your nuts!'"
            );

            StoryNode wrongAnswer4 = new StoryNode(
                "The dragon sighs. 'Nope! Looks like you need to crack more books.'"
            );

            StoryNode firstPun = new StoryNode(
                "The dragon asks: 'Why did the hazelnut go to school?'"
            )
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "A) To become a peanut",
                    "B) To learn"
                }
            };

            StoryNode correctPun1 = new StoryNode(
                "The dragon chuckles. 'Looks like you’ve cracked the shell of knowledge!'"
            );

            StoryNode wrongPun1 = new StoryNode(
                "The dragon groans. 'That was nuts! Let’s try again.'"
            );

            StoryNode secondPun = new StoryNode(
                "The dragon smirks and asks: 'What do you call a hazelnut that tells jokes?'"
            )
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "A) Cracked nut",
                    "B) Nutty professor"
                }
            };

            StoryNode correctPun2 = new StoryNode(
                "The dragon laughs. 'Nutty! Let’s keep going.'"
            );

            StoryNode thirdPun = new StoryNode(
                "The dragon leans back. 'Why did the hazelnut become a detective?'"
            )
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "A) To crack the case",
                    "B) To solve the mystery"
                }
            };

            StoryNode correctPun3 = new StoryNode(
                "The dragon chuckles. 'Cracked it! You’re good at this.'"
            );

            StoryNode fourthPun = new StoryNode(
                "The dragon tilts its head. 'What’s a hazelnut’s favorite type of music?'"
            )
            {
                RequiresInput = true,
                OptionsDescriptions = new List<string>
                {
                    "A) Rock-nut-roll",
                    "B) Smooth jazz"
                }
            };

            StoryNode correctPun4 = new StoryNode(
                "The dragon claps. 'Rock on! Let’s continue.'"
            );

            StoryNode floor5 = new StoryNode("You have escaped to the next floor.");


            floor4.Options.Add("play", firstQuestion);

            firstQuestion.Options.Add("italy", wrongAnswer1);
            firstQuestion.Options.Add("turkey", correctAnswer1);

            correctAnswer1.Options.Add("continue", secondQuestion);
            wrongAnswer1.Options.Add("try", firstPun);

            firstPun.Options.Add("peanut", correctPun1);
            firstPun.Options.Add("learn", wrongPun1);
        
            correctPun1.Options.Add("next", secondQuestion);
            wrongPun1.Options.Add("retry", firstQuestion);

            secondQuestion.Options.Add("ice age", correctAnswer2);
            secondQuestion.Options.Add("shrek", wrongAnswer2);

            correctAnswer2.Options.Add("advance", thirdQuestion);
            wrongAnswer2.Options.Add("retry", secondPun);

            secondPun.Options.Add("cracked", correctPun2);
            secondPun.Options.Add("professor", wrongPun1);
            
            correctPun2.Options.Add("continue", thirdQuestion);

            thirdQuestion.Options.Add("coffee", correctAnswer3);
            thirdQuestion.Options.Add("tea", wrongAnswer3);

            correctAnswer3.Options.Add("move", fourthQuestion);
            wrongAnswer3.Options.Add("retry", thirdPun);

            thirdPun.Options.Add("crack", correctPun3);
            thirdPun.Options.Add("solve", wrongPun1);

            correctPun3.Options.Add("next", fourthQuestion);

            fourthQuestion.Options.Add("vitamin e", correctAnswer4);
            fourthQuestion.Options.Add("vitamin c", wrongAnswer4);

            correctAnswer4.Options.Add("finish", floor5);
            wrongAnswer4.Options.Add("retry", fourthPun);

            fourthPun.Options.Add("rock", correctPun4);
            fourthPun.Options.Add("jazz", wrongPun1);

            
            correctPun4.Options.Add("continue", floor5);

            floor5.Options.Add("proceed", new Floor5().GetStartNode());


            return floor4;
        }

        public StoryNode GetStartNode()
        {
            return CurrentNode!;
        }
    }
}
