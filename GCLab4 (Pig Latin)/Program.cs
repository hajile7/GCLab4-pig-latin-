﻿//infinite program loop
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

bool runProgram = true;
while (runProgram) {

    //welcome message
    Console.WriteLine("Welcome to the pig latin translator");

    //get user input
    Console.WriteLine("Please enter a word or sentence you'd like translated");
    string word = Console.ReadLine().Trim(); //removed ToLower() to satify extendeds

    //make sure string is not empty and loop to get good input
    while (word == "")
    {
        Console.WriteLine("Invalid input. Please enter the word you would like translated: ");
        word = Console.ReadLine().Trim();
    }
    /*this loop is going to tell us the position of the first vowel in the given word. once there, we break from the loop.
     * based on this vowel position, we can break up the word to create its Pig Latin translation. This also allows for 
     * punctuation to be included in our user input so long as the punctuation doesn't push the first vowel outside of the
     * first 5 spots. Could hard code more cases, but assuming there is more efficient way
     */
    string[] words = word.Split(" "); //create an array of strings isolate the words in a provided sentence
    foreach (string w in words) //use a foreach loop to run each word in the array through the vowelSpot code and sorting conditionals
    {
        int vowelSpot = -1;
        {
            foreach (char letter in w)
            {
                vowelSpot += 1;
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                {
                    break;
                }
            }
        }
        //create strings for translated word
        string translatedWord = "";
        string beforeLetters = "";
        string afterLetters = "";

        //hard coded line checking for special characters. Could not get a functioning solution using ascii/unicode or the .IsSymbol method. .IsPuncutation didn't get me there either.
        if (hasNumber(w) || w.Contains("@") || w.Contains("$") || w.Contains("#") || w.Contains("%") || w.Contains("^") || w.Contains("*") || w.Contains("(") || w.Contains(")") || w.Contains("_") || w.Contains("=") || w.Contains("+") || w.Contains("[") || w.Contains("]") || w.Contains("{") || w.Contains("}") || w.Contains(">") || w.Contains("<"))
        {
            translatedWord = word;
        }
        //translating conditionals whose rules are based on the first vowel position. I've included up until position 5
        else if (vowelSpot == 0)
        {
            translatedWord = w + "way";
        }
        else if (vowelSpot == 1)
        {
            beforeLetters = w.Substring(0, 1);
            afterLetters = w.Substring(1);
            translatedWord = afterLetters + beforeLetters + "ay";
        }
        else if (vowelSpot == 2)
        {
            beforeLetters = w.Substring(0, 2);
            afterLetters = w.Substring(2);
            translatedWord = afterLetters + beforeLetters + "ay";
        }
        else if (vowelSpot == 3)
        {
            beforeLetters = w.Substring(0, 3);
            afterLetters = w.Substring(3);
            translatedWord = afterLetters + beforeLetters + "ay";
        }
        else if (vowelSpot == 4)
        {
            beforeLetters = w.Substring(0, 4);
            afterLetters = w.Substring(4);
            translatedWord = afterLetters + beforeLetters + "ay";
        }
        else if (vowelSpot == 5)
        {
            beforeLetters = w.Substring(0, 5);
            afterLetters = w.Substring(5);
            translatedWord = afterLetters + beforeLetters + "ay";
        }

        //show user their translated word
        Console.Write(translatedWord + " ");
    
    }
    //ask user if they'd like to translate another word or sentence
    while (true)
    {
        Console.WriteLine("\nWould you like to translate another word or sentence? y/n");
        string progChoice = Console.ReadLine().ToLower().Trim();
        if (progChoice == "y")
        {
            break;
        }
        else if (progChoice == "n")
        {
            Console.WriteLine("Thank you for using the Pig Latin translator!");
            runProgram = false;
            break;
        }
    }
}

//method to check for number in input
bool hasNumber(string inputString)
{
    return inputString.Any(ch => char.IsDigit(ch));
}
