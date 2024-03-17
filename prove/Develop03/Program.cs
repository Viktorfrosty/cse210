/*
Exceeding requirements:
- Added a try and catch blocks to handle invalid inputs.
- Added .ToLower() to the user selection to respond to upper case or lower case "quit" userSelection.
- the program can hide diferent words from the words list, and it does not select the same word twice.
- added a restart function to the user selection, it will show all the words again.
*/

using System;
using Assingment;

class Program
{
    static void Main(string[] args)
    {

        Scripture selectedScripture = new Scripture("test1 test2, test3. Test4.");

        bool hiddenStatus = selectedScripture.IsCompletlyHidden();

        Console.Clear();

        while (hiddenStatus == false)
        {

            try
            {

                selectedScripture.DisplayText();

                hiddenStatus = selectedScripture.IsCompletlyHidden();

                Console.Write($"\nPress the enter button to continue in the program or write 'quit' to exit the program.\nSelection: ");

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

                    Console.WriteLine($"Invalid selection: You must write 'quit' to exit the program or just press the enter button to continue in the program.\n");

                }

            }
            catch (Exception)
            {

                hiddenStatus = false;

                Console.Clear();

                Console.WriteLine($"Invalid selection: You must write 'quit' to exit the program or just press the enter button to continue in the program.\n");

            }

        }

        if (hiddenStatus == true)
        {

            Console.WriteLine("Goodbye.");

        }

    }

}