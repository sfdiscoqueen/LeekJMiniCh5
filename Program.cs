// Jasmine Leek
// 19oct2022
// Mini Challenge #5 "Mad Lib"
// This is a program that asks a user to create a silly short story using input from the user

Console.Clear();
bool playAgain = true;
while (playAgain)
{
    Console.WriteLine("Let's play MadLibs! Before we get started, here are some helpful reminders: \n");
    Console.WriteLine("You'll be asked to enter nouns, verbs, adjectives, and adverbs.");
    Console.WriteLine("--> Nouns are names of person, places, or things.");
    Console.WriteLine("--> Verbs are action words.");
    Console.WriteLine("--> Adjectives are descriptive words. They modify or describe nouns.");
    Console.WriteLine("--> Adverbs modify a verb, adjective, or another adjective. They frequently end in -ly.\n");
    Console.WriteLine("Let's get started! What's your name?");

    string name = Console.ReadLine();

    Console.WriteLine($"\n*.*.* Hello, {name}! It's nice to meet you *.*.*\n");

    Console.WriteLine("1. Enter a noun (animal):");
    string noun1 = Console.ReadLine();

    Console.WriteLine("2. Enter a noun (animal):");
    string noun2 = Console.ReadLine();

    Console.WriteLine("3. Enter a noun (place):");
    string noun3 = Console.ReadLine();

    Console.WriteLine("4. Enter a number (greater than 1):");
    string num1 = Console.ReadLine();

    Console.WriteLine("5. Enter an adjective:");
    string adj1 = Console.ReadLine();

    Console.WriteLine("6. Enter an adverb:");
    string adv1 = Console.ReadLine();

    Console.WriteLine("7. Enter a verb:");
    string verb1 = Console.ReadLine();

    Console.WriteLine("8. Enter an adjective:");
    string adj2 = Console.ReadLine();

    Console.WriteLine("9. Enter an adjective:");
    string adj3 = Console.ReadLine();

    Console.WriteLine("10. Enter an adjective:");
    string adj4 = Console.ReadLine();

    Console.WriteLine("\nAwesome sauce. Here's your MadLibs story:\n");
    
    Console.WriteLine($"In a far away town, there lived a unique couple: the {noun1} and the {noun2}.\n");
    Console.WriteLine($"One day, while returning home to the {noun3} after a long day's work, they found {num1} magic beans.");
    Console.WriteLine($"The {noun1} was so {adj1} and told the {noun2} they needed to {adv1} {verb1} back home! \nThe magic beans would disappear overnight if they weren't planted.\n");
    
    Console.WriteLine($"According to legend, the {noun1} said, each bean would grant them a single wish, and they had {num1} wishes in store.");
    Console.WriteLine($"The {noun2} looked {adj2}, and then got to work preparing the soil to plant each of the {num1} magic beans.");
    Console.WriteLine($"Once it was time to plant the first magic bean, the {noun1} asked the {noun2} what their first wish would be.");
    Console.WriteLine($"The {noun2} replied: 'The time has finally come! I wish for a {adj3}, {adj4} shovel!'");
    Console.WriteLine($"The {noun1} laughed and they lived happily ever after! THE END.\n");

    Console.WriteLine("Want to play again? \n \nEnter any key to restart or type 'end' to quit: ");

    string ready = Console.ReadLine();
    Console.WriteLine(" ");
    if (ready == "end")
    {
        playAgain = false;
    }

}
