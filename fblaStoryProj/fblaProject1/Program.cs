

//condenses the sad merchant dialogue
Action actionSad = () => Console.WriteLine("The man, seemingly dissapointed, suddenly disappears in a cloud of smoke, leaving you once again alone.");

//this section condenses the frequently used trail dialogue
Action actionTrail = () =>
{
    Console.WriteLine("There are two paths before you, a lush garden trail, and a thorny, forested path.");
    Console.WriteLine("Do you go through the garden or the forest?");
};

//condenses garden text
Action actionGarden =  () =>
{
    
        
        
        
        
        Console.WriteLine("You walk down the trail, but as you do so, you begin to notice that the garden is eerily empty, even for the standards of a garden.");
        Console.WriteLine("Your mind begins to wander, as you question: 'Why is there even a garden here anyway? Nobody lives nearby, and the nearest village is at least a hour away.'");
        Console.WriteLine("You try to listen for any nearby animals, but alas, it is comepletely quiet. Except for one thing. A strange droning sound.");
        Console.WriteLine("The strange part of this sound is that you cannot seem to determine any location from it. And it hurts. A lot.");
        Console.WriteLine("It gets worse. And as you struggle to keep walking, you realize that there is no garden. It was just an illusion created to keep you in one area.");
        Console.WriteLine("You never actually left the crossroads. It was all done so that your mana could be stolen.");
        

};

//condenses forest text
Action actionForest = () =>
{
    Console.WriteLine("As you walk, the forest begins to become more and more peaceful. It eventually feels normal as you walk.");
    Console.WriteLine("The forest is filled with all kinds of animals: Squirrels, mice, foxes, wolves, and even the occasional bear.");
    Console.WriteLine("You decide to sit down and just enjoy the view, take in the smells, and simply live in the moment.");
    Console.WriteLine("Wanderer - This... is beautiful. It has been long since I have felt this peaceful. I... I needed this.");
    Console.WriteLine("You get up. After all, you need to get moving, as your next meal isn't going to come from nowhere.");
    Console.WriteLine("You return to the crossroads. You notice that, upon reviewing, there is only one entrance to the forest.");
    Console.WriteLine("Wanderer - Hang on... Wasn't there a second path here? There was the garden looking one... Where did it... ?");
    Console.WriteLine("The truth is, you were correct, there was two paths. However, only one was real. The other was a magic based trap, in order to lure people and steal their mana.");
    Console.WriteLine("You begin to feel empowered. You decide that the reasoning isn't particularly important right now, and return to town.");
    Console.WriteLine("You ask around, and everyone feels the same. The sick begin to heal, and the paralized begin to walk again.");
    Console.WriteLine("The reason the second path dissapeared was not because it was fake, but it simply was made of mana.");
    Console.WriteLine("It appeared to you beacuse its constructor, a mana siphoner, was nearly out of mana, which is needed to keep itself alive. And with it gone, the mana returns to everyone it was stolen from.");
    Console.WriteLine("You win. Brilliant job.");
};




Console.WriteLine("This story is done entirely within the console, so I must tell you that you must answer the questions with either 'y' or 'n' unless specified.");

Console.WriteLine("The story begins with a wandering warrior, crossing the lands in search of adventure. You are that wanderer.");
Console.WriteLine("??? - Greetings traveler! It is so good to finally meet you...");
Console.WriteLine("Do you humor the strange man and reply?");

if (Console.ReadLine() == "y")
{
    Console.WriteLine("Wanderer - Hello odd stranger. What business do you have with me?");
    Console.WriteLine("Mysterious Stranger - Oh... I'm just a huge fan of your work. However, if you are seeking potions then I have just what you need...");
    Console.WriteLine("You see the alchemist open his greatcoat, revealing a set of 3 potions: A set of purple potions, a set of red potions, and a green, much smaller set of potions.");
    Console.WriteLine("Do you purchase them?");

    if (Console.ReadLine() == "y")
    {
        Console.WriteLine("You take one of each and give the man his money. After you do so, he disappears in a black cloud of smoke.");
        actionTrail();

        if (Console.ReadLine() == "the garden" || Console.ReadLine() == "garden")
        {
            actionGarden();
            Console.WriteLine("Would you like to try to drink a potion?");

            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("You decide it's now or never, and drink all of the potions at once. You feel as energy suddenly surges through you, and overpower the mana siphoner.");
                Console.WriteLine("You return to town and discover that you did them all a great favor. The townsfolk have been suffering from the same machine for years. You win.");
            }
            else
            {
                Console.WriteLine("Your life slips away and your body gives out. You die, please reset the program.");
            }
        }

        else
        {
            actionForest();
        }
    }

    else
    {
        actionSad();

        actionTrail();

        if (Console.ReadLine() == "the garden" || Console.ReadLine() == "garden")
        {
            actionGarden();

            Console.WriteLine("You die. Please reset the program.");

        }

        else
        {
            actionForest();
        }

    }
}

else
{
    Console.WriteLine("The man, seemingly dissapointed, suddenly disappears in a cloud of smoke, leaving you once again alone.");
    Console.WriteLine("This is not entirely a bad thing however, as it leaves you free to continue without fear of potential backstabbing or evil intent.");

    actionTrail();

    if (Console.ReadLine() == "the garden" || Console.ReadLine() == "garden")
    {
        actionGarden();

        Console.WriteLine("You die. Please reset the program.");

    }

    else
    {
        actionForest();
    }
}

