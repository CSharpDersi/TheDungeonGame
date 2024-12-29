using The_HoshBesh.Classes;

internal class Floor2 : BaseFloor
{
    public Floor2()
    {
        CurrentNode = BuildStory();
    }

    protected override StoryNode BuildStory()
    {

        StoryNode floor2 = new StoryNode("You step into a zesty realm filled with the tangy aroma of citrus. The walls glisten as if coated in lime juice, and the floor feels oddly soft underfoot, like stepping on lime rinds. A voice booms: 'Welcome to Lime's domain! I'll be your sour host. Remember this: Life gives you limes, but it's what you do with them that matters. Oh, and… don't slip!' The voice fades, leaving you at the crossroads of two paths.");

        StoryNode greenPath = new StoryNode("As you follow the shimmering path, Lime's voice echoes again, dripping with sarcasm: 'Ah, taking the shiny road, I see. Classic choice. Let's see if it's your brightest one.' The path leads to a lime grove, where each tree bears a single glowing fruit. A sign reads: 'Pick the fruit that's not what it seems.'");

        StoryNode sourPath = new StoryNode("The shadows seem to close in as you walk this path. The air grows thick, and suddenly, you're surrounded by a dense citrus fog. Lime's laughter echoes: 'Brave, aren't you? But bravery can be... sour. Let's test your memory! What was the first thing I told you when you entered my domain?' You pause, trying to recall.");

        StoryNode dullLime = new StoryNode("You pick the dull lime, and suddenly, the ground begins to shake. The lime bursts open, revealing a key! Lime's voice chuckles approvingly: 'Not bad. You've got an eye for the underdog. Keep that up, and you might survive.' A door materializes ahead, glowing green. As it opens, two paths reveal themselves.");

        StoryNode goldenLime = new StoryNode("The golden lime is soft in your hand—too soft. Suddenly, it explodes in a spray of sour juice! Lime's laughter roars: 'Oh, you went for the obvious? How… predictable. Back to the start!' However, the start feels… different. Two new possibilities emerge.");

        StoryNode repeatWords = new StoryNode("You recall Lime's words and repeat them aloud. The fog clears instantly, and Lime's voice whispers: 'Impressive. You were paying attention. Proceed, my clever traveler.' Ahead, the citrus maze twists into view. Two paths lie before you.");

        StoryNode wrongPhrase = new StoryNode("You confidently say, 'Don't slip!' Lime bursts into laughter: 'Oh, darling, that's cute, but wrong. Back to the start for a proper squeeze!' Yet this time, the environment shifts.");

        StoryNode limeClocks = new StoryNode("The glowing door opens, revealing a room filled with lime-colored clocks, all ticking at different speeds. Lime's voice echoes: 'Time is sour. Can you sweeten it? Solve the riddle: Which clock tells the time that isn't there?'");

        StoryNode chamberVines = new StoryNode("The door opens into a chamber of vines. Lime whispers: 'The path ahead twists like a lime peel. One way leads to safety, the other… well, you'll find out. Choose wisely.'");

        // Node 4C
        StoryNode revisedStartLime = new StoryNode("You find yourself back at the start, but this time, a new lime glows on the table. Lime’s voice teases: ‘Alright, sour one, redemption awaits.Which lime will you pick now?’");

        // Node 4D
        StoryNode shimmeringLimePath = new StoryNode("You return to the foggy start, but a shimmering lime path appears. Lime laughs: ‘Second chances are a rare treat. Will you take the same route or find something new?’");

        // Node 4E
        StoryNode citrusMaze = new StoryNode("The citrus maze twists ahead. Lime’s voice sings: ‘A maze of choices. Which citrus will guide you?’ Two symbols appear on the maze walls:");

        // Node 4F
        StoryNode limePoolReflection = new StoryNode("Deeper in the maze, a lime-colored pool reflects your image. Lime whispers: ‘What do you see? Truth or illusion? Step forward, but only if you dare.’");

        // Node 4G
        StoryNode foggyStartTwist = new StoryNode("You’re back at the start, but the fog is thicker. Lime chuckles: ‘Stubbornness is sour. Can you twist your way out this time?’");

        // Node 4H
        StoryNode citrusStorm = new StoryNode("A citrus storm swirls around you, pushing you forward. Lime’s voice warns: ‘Step carefully, or you’ll fall. Do you trust your steps or my storm?’");

        StoryNode slowClockWin = new StoryNode("You focus on the slowest clock. As you gently adjust its hands, the ticking synchronizes with your heartbeat. Lime's voice booms: 'Patience, my sweet sour traveler, is always rewarded. Go on, you've earned your passage!' The next door opens, revealing the exit of Lime's realm and a glowing green gem as your prize.");

        StoryNode outwardVinesWin = new StoryNode("The outward-growing vines guide you to a golden pedestal. Lime whispers: 'Light reveals the truth. You've found the key to balance. Well done!' The lime vines part, leading to an exit bathed in sunlight, Lime's grin fading as you leave with a lime-colored crystal.");

        // Node 5C1
        StoryNode glowingLimeKey = new StoryNode("The glowing lime in your hand vibrates, and Lime’s voice whispers: ‘Ah, you’ve chosen courage over comfort. Sweet and sour rewards await!’ The lime transforms into a glowing key that unlocks the next passage to freedom.");

        // Node 5D1
        StoryNode shimmeringLimeVictory = new StoryNode("The shimmering lime path grows brighter, leading you to Lime’s chamber. Lime nods approvingly: ‘Finally, you’ve found me. Let’s end this sour dance.’ Lime engages you in a battle of wits. Upon victory, Lime gifts you a glowing lime shard, granting access to the exit.");

        // Node 5E1
        StoryNode limeCarvingPath = new StoryNode("The lime carving glows brighter as you touch it. Lime’s voice hums: ‘You’ve embraced the sour truth. Well done!’ The maze transforms, creating a clear path to the exit and leaving you with a citrus gem.");

        // Node 5F1
        StoryNode limePoolTrinket = new StoryNode("Stepping into the lime pool, you find yourself floating on citrus bubbles. Lime smiles: ‘Clever and bold. The way forward is yours!’ The bubbles lift you to the exit, where you find a lime-enchanted trinket.");

        // Node 5G1
        StoryNode incantationClearedFog = new StoryNode("Your new incantation clears the fog, revealing Lime’s true form. Lime claps: ‘Persistence is sour but powerful. I yield to you, traveler. Go forth!’ The dragon steps aside, letting you pass to the final chamber.");

        // Node 5H1
        StoryNode defyCitrusStormRelic = new StoryNode("Defying the citrus storm, you find Lime watching, impressed. The dragon bows: ‘Strength is sweet and sour. You’ve proven yourself worthy. Go on.’ The storm dissipates, revealing the exit and a lime-shaped relic as your prize.");

        // Losing Nodes

        // Node 5A2
        StoryNode fastClockLose = new StoryNode("The fastest clock shatters into lime fragments as you touch it, and the room grows dark. Lime laughs: 'Speed is sour but rarely sweet. Back to the start with you!' The player is teleported to the first room of Lime's domain. Are you ready? ");

        // Node 5B2 
        StoryNode inwardVinesLose = new StoryNode("The inward-growing vines tighten around you, and Lime's voice growls: 'Darkness is a trap you should have avoided. Start again, or the sour end is near!' The vines pull the player back to the beginning of Lime's domain.");

        // Node 5C2
        StoryNode dullLimeBackStart = new StoryNode("The dull lime works once more, but Lime’s voice is sharp this time: ‘You’ve learned nothing new. Safe choices are a sour ending. Try again!’ The room dissolves, sending the player back to the start.");

        // Node 5D2
        StoryNode citrusGasBackStart = new StoryNode("Returning to the original path, you find it blocked by sour citrus gas. Lime sighs: ‘You’ve chosen familiarity over bravery. Go back and try again.’ The gas pushes you back to the start.");

        // Node 5E2
        StoryNode orangeCarvingBackStart = new StoryNode("The orange carving turns to dust, and Lime sneers: ‘Oranges have no place here. Back to the sour start!’ The maze reconfigures, and the player finds themselves back at the beginning.");

        // Node 5F2
        StoryNode limePoolTrap = new StoryNode("Walking past the pool, you trigger a trap. Lime growls: ‘Cowardice is sour indeed. Back to where you started!’ The ground collapses, dropping the player back to the first chamber.");

        // Node 5G2
        StoryNode thickeningFogBackStart = new StoryNode("Retracing your steps, you realize the fog grows thicker. Lime sneers: ‘Wrong way, traveler. Back to square one!’ You are teleported to the first room.");

        // Node 5H2
        StoryNode stormStrengthBackStart = new StoryNode("Waiting for the storm to calm, it instead grows stronger, forcing you backward. Lime laughs: ‘Patience has no place here! Back to where you began!’ You are blown back to the start of the Lime’s realm.");

        StoryNode escapeFloor3 = new StoryNode("You have escaped to the next floor.");
        StoryNode escapeFloor2 = new StoryNode("You have escaped to the before floor.");

        floor2.Options.Add("follow the green path", greenPath);
        floor2.Options.Add("take the shadowy trail", sourPath);

        greenPath.Options.Add("pick the golden lime", goldenLime);
        greenPath.Options.Add("pick the dull lime", dullLime);

        sourPath.Options.Add("life gives you limes, but it's what you do with them that matters", repeatWords);
        sourPath.Options.Add("don't slip", wrongPhrase);

        dullLime.Options.Add("enter the glowing door", limeClocks);
        dullLime.Options.Add("step into the chamber of vines", chamberVines);

        goldenLime.Options.Add("go for the dull lime", shimmeringLimePath);
        goldenLime.Options.Add("try the glowing lime again", revisedStartLime);

        repeatWords.Options.Add("follow the orange carving’s faint golden glow", limePoolReflection);
        repeatWords.Options.Add("follow the lime carving’s faint green glow", citrusMaze);

        wrongPhrase.Options.Add("try a new incantation", foggyStartTwist);
        wrongPhrase.Options.Add("retrace your steps", citrusStorm);

        limeClocks.Options.Add("look at the fastest clock", fastClockLose);
        limeClocks.Options.Add("examine the slowest clock", slowClockWin);

        chamberVines.Options.Add("follow the outward vines", outwardVinesWin);
        chamberVines.Options.Add("follow the inward vines", inwardVinesLose);
        //c
        revisedStartLime.Options.Add("pick the glowing lime, trusting its strange energy", glowingLimeKey);
        revisedStartLime.Options.Add("pick the dull lime again", dullLimeBackStart);
        //d
        shimmeringLimePath.Options.Add("follow the shimmering lime path", shimmeringLimeVictory);
        shimmeringLimePath.Options.Add("return to the original path", citrusGasBackStart);
        //e
        citrusMaze.Options.Add("turn back and choose the orange carving", orangeCarvingBackStart);
        citrusMaze.Options.Add("continue along the green lime path", limeCarvingPath);
        //f
        limePoolReflection.Options.Add("step into the pool", limePoolTrinket);
        limePoolReflection.Options.Add("walk past the pool", limePoolTrap);
        //g
        foggyStartTwist.Options.Add("retrace your steps", thickeningFogBackStart);
        foggyStartTwist.Options.Add("step forward into the final chamber", incantationClearedFog);
        //h
        citrusStorm.Options.Add("step forward confidently", defyCitrusStormRelic);
        citrusStorm.Options.Add("wait for the storm to calm", stormStrengthBackStart);

        slowClockWin.Options.Add("enter", escapeFloor3);
        outwardVinesWin.Options.Add("enter", escapeFloor3);
        glowingLimeKey.Options.Add("enter", escapeFloor3);
        shimmeringLimeVictory.Options.Add("enter", escapeFloor3);
        limeCarvingPath.Options.Add("enter", escapeFloor3);
        limePoolTrinket.Options.Add("enter", escapeFloor3);
        incantationClearedFog.Options.Add("enter", escapeFloor3);
        defyCitrusStormRelic.Options.Add("enter", escapeFloor3);

        fastClockLose.Options.Add("yes", escapeFloor2);
        inwardVinesLose.Options.Add("yes", escapeFloor2);
        dullLimeBackStart.Options.Add("yes", escapeFloor2);
        citrusGasBackStart.Options.Add("yes", escapeFloor2);

        orangeCarvingBackStart.Options.Add("yes", escapeFloor2);
        limePoolTrap.Options.Add("yes", escapeFloor2);
        thickeningFogBackStart.Options.Add("yes", escapeFloor2);
        stormStrengthBackStart.Options.Add("yes", escapeFloor2);
        
    


        escapeFloor3.Options.Add("proceed", new Floor3().GetStartNode());
        escapeFloor2.Options.Add("proceed", null);

        return floor2;
    }

    public StoryNode GetStartNode()
    {
        return CurrentNode;
    }
}
