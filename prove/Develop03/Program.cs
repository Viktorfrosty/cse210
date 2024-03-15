/*
*/

using System;
using Assingment;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write($"You must press the enter button to continue in the program or write 'quit' to exit the program.\nSelection: ");

        while (true)
        {

            try
            {

                string userSelection = Console.ReadLine();

                if (userSelection.ToLower() == "quit")
                {
                    break;
                }
                else if (userSelection.ToLower() == "" /* || userSelection.ToLower() == "a" */)
                {
                    Console.Clear();
                    Console.WriteLine($"Test");
                }
                else
                {
                    Console.Write($"\nInvalid selection: You must write 'quit' to exit the program or just press the enter button to continue in the program.\nSelection: ");
                }

            }

            catch (Exception)
            {

                Console.Write($"\nInvalid selection: You must write 'quit' to exit the program or just press the enter button to continue in the program.\nSelection: ");

            }

        }

    }

}