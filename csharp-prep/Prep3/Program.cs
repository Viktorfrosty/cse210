using System;

class Program
{
    static void Main(string[] args)
    {
        string playTheGame = "yes";

        while ( playTheGame == "yes" )
        {
            // User selected number:
            /*
            Console.Write("Insert the magic number: ");
            string userInitialSelection = Console.ReadLine();
            int magicNumber = int.Parse(userInitialSelection); 
            */
            // Random selected number:

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next( 1, 101 );

            int userNumber = magicNumber - 1;

            // Challenges

            int userIntents = 1;

            while ( userNumber != magicNumber )
            {
                Console.Write("What's your guess? ");
                string userSelection = Console.ReadLine();
                userNumber = int.Parse(userSelection);

                if ( userNumber > magicNumber )
                {
                    userIntents += 1;
                    Console.WriteLine("\nThe magic number has a lower value, try again.\n");
                }
                else if ( userNumber < magicNumber )
                {
                    userIntents += 1;
                    Console.WriteLine("\nThe magic number has a higher value, try again.\n");
                }
                else
                {
                    Console.WriteLine($"\nYou made it! {userNumber} is the magic number.");
                    // Challenge
                    Console.WriteLine($"It took you {userIntents} attempts to guess the right number.\n");
                    Console.Write("Play again? ( yes / no ): ");
                    playTheGame = Console.ReadLine();
                }
            }
        }
    }
}