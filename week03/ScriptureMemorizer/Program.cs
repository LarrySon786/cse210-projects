using System;

class Program
{
    static void Main(string[] args)
    {
        int speedWordsHide = 5;
        Console.WriteLine("Select your difficulty - easy, medium, or hard: ");
        string difficulty = Console.ReadLine();
        if (difficulty == "easy")
        {
            speedWordsHide = 8;
        }
        else if (difficulty == "medium")
        {
            speedWordsHide = 15;
        }
        else if (difficulty == "hard")
        {
            speedWordsHide = 25;
        }
        Console.Clear();
        string answer = "enter";
        Scripture memorizedScripture = new Scripture();

        do
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Push enter to remove more words.");
            Console.WriteLine("Type 'quite' to quite the program");
            Console.WriteLine("");

            memorizedScripture.GetDisplayText();
            answer = Console.ReadLine();

            memorizedScripture.HideRandomWords(speedWordsHide);
            if (memorizedScripture.CheckHidden() == true)
            {
                break;
            }
        } while (answer != "quite");

        Console.Clear();
        if (answer != "quite")
        {
            memorizedScripture.GetDisplayText();
            string pause = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(memorizedScripture.WriteReference());
            Console.WriteLine("");
            memorizedScripture.GetOriginalText();
            Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine("Thanks for playing");
    }
}


// Class 1 Scripture: Store Reference, Store complete text
// Class will need propper spacing for multiple versed scriptures.
// Class 1 method to limit the amount of text and replace it with _. This method will need to accept a parameter like 20% 40% 50% ect
// The number of "_" should be equal to the number of letters in that word.
// Class 1 method 2 to clear the screen and display the scripture reference and full verses.
//Is able to hide multiple words
// Methods - Select random words, iterate through the text and replace the words with the propper number of _ from the other methods 
// Method - get display text (both normal and _ words)
// XXXXXXXXMethods - Display the full reference and text upon 100% completion
// XXXXXXMethods - Display the full reference and text upon quiting.
//Methods - detect if scripture is 100% hidden.

// Class 2 Scripture Reference. Stores Book, Chapter, Verses
// Methods - Store information in variable, get information
//

// Class 3 Scripture's Word. Keep's track of a single word and how many _ in it
// Methods -- Hide - Count the number of letters in a word passed in as parameter. Return number of _ _
// Methods -- Show - Go through each word and display normal text.
// Methods -- check if word is hidden or not. 


// We will need to use multiple constructors for the case of multi-versed scriptures.

// main function:
// Prompt the user for enter key to contiune or quite to end program
// each time the word 'enter' is pressed, the program will hide a larger number of words.
// when all words in program are _, the program should end.
// When it ends this way, it should then display the full scripture reference and verse.

//Requirements
// Use PRIVATE on all items as much as possible
// 