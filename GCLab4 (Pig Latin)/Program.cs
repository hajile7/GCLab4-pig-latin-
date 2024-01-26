//infinite program loop
using System.ComponentModel.Design;

bool runProgram = true;
while (runProgram) {

    //welcome message
    Console.WriteLine("Welcome to the pig latin translator");

    //get input
    Console.WriteLine("Please enter a word you'd like translated");
    string word = Console.ReadLine().ToLower().Trim();


    /*this loop is going to tell us the position of the first vowel in the given word. once there, we break from the loop.
     * based on this vowel position, we can more easily follow the provided rules for pig latin
     */
    int vowelSpot = -1;
    foreach (char letter in word)
    {
        vowelSpot += 1;
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            break;
        }
    }

    //create string for translated word + sections of the word that we will use in our for loop
    string translatedWord = "";
    string beforeLetters = "";
    string afterLetters = "";

    //translating loops whose rules are based on the first vowel position. I've included up until position 5 because the word pyhrric exists.
    if (vowelSpot == 0)
    {
        translatedWord = word + "way";
    }
    else if (vowelSpot == 1)
    {
        beforeLetters = word.Substring(0, 1);
        afterLetters = word.Substring(1);
        translatedWord = afterLetters + beforeLetters + "ay";
    }
    else if (vowelSpot == 2)
    {
        beforeLetters = word.Substring(0, 2);
        afterLetters = word.Substring(2);
        translatedWord = afterLetters + beforeLetters + "ay";
    }
    else if (vowelSpot == 3)
    {
        beforeLetters = word.Substring(0, 3);
        afterLetters = word.Substring(3);
        translatedWord = afterLetters + beforeLetters + "ay";
    }
    else if (vowelSpot == 4)
    {
        beforeLetters = word.Substring(0, 4);
        afterLetters = word.Substring(4);
        translatedWord = afterLetters + beforeLetters + "ay";
    }
    else if (vowelSpot == 5)
    {
        beforeLetters = word.Substring(0, 5);
        afterLetters = word.Substring(5);
        translatedWord = afterLetters + beforeLetters + "ay";
    }

    //show user their translated word
    Console.WriteLine(translatedWord);

    //ask user if they'd like to continue using the program
    while (true)
    {
        Console.WriteLine("Would you like to translate another word? y/n");
        string progChoice = Console.ReadLine().ToLower().Trim();
        if (progChoice == "y")
        {
            break;
        }
        else if (progChoice == "n")
        {
            Console.WriteLine("Thank you for using the pig lating translator!");
            runProgram = false;
            break;
        }
    }
}


