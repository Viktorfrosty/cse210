/*
Exceeding requirements:
- Added a try and catch blocks to handle invalid inputs.
- Added .ToLower() to the user selection to respond to upper case or lower case "quit" userSelection.
- the program can hide diferent words from the words list, and it does not select the same word twice.
- added a restart function to the user selection, it will show all the words again.
- The program does not erase any dot or comma in the _text from words.
*/

using System;
using Assingment;

class Program
{
    static void Main(string[] args)
    {

        string book = "test";

        int chapter = 0;

        int verse = 0;

        int endVerse = 1;

        string text = "test1 test2, test3. Test4.";

        Reference reference = new Reference(book,chapter,verse,endVerse);

        Scripture selectedScripture = new Scripture(reference,text);

        bool hiddenStatus = selectedScripture.IsCompletlyHidden();

        Console.Clear();

        while (hiddenStatus == false)
        {

            try
            {

                selectedScripture.DisplayText();

                hiddenStatus = selectedScripture.IsCompletlyHidden();

                Console.Write($"\nPress the 'Enter' key to continue, write 'restart' to show all the words again or 'quit' to exit the program.\nSelection: ");

                string userSelection = Console.ReadLine();

                if (userSelection.ToLower() == "quit")
                {

                    Console.WriteLine($"\nGoodbye.");

                    break;

                }
                else if (userSelection == "")
                {

                    Console.Clear();

                    selectedScripture.HideRandomWords(2);

                }
                else if (userSelection.ToLower() == "restart")
                {

                    Console.Clear();

                    selectedScripture.ShowAllWords();

                    hiddenStatus = false;

                }
                else
                {

                    hiddenStatus = false;

                    Console.Clear();

                    Console.WriteLine($"Invalid selection: You must write 'quit' to exit the program, 'restart' to show all the words again, or just press the 'Enter' key to continue in the program.\n");

                }

            }
            catch (Exception)
            {

                hiddenStatus = false;

                Console.Clear();

                Console.WriteLine($"Invalid selection: You must write 'quit' to exit the program, 'restart' to show all the words again, or just press the 'Enter' key to continue in the program.\n");

            }

        }

        if (hiddenStatus == true)
        {

            Console.WriteLine("Good Work, goodbye.");

        }

    }

}