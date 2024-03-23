/*
Exceeding Requirements:
- Added a try and cath block to handle invalid inputs.
-
*/

using System;
using Mindfulness;

class Program
{

    static void Main(string[] args)
    {

        bool running = true;

        Console.Clear();

        Console.WriteLine("Mindfulness Program");
        
        while (running == true)
        {

            try
            {

                Console.Write("Options:\n1. Start Breathing Activity.\n2. Start reflecting Activity.\n3. Start Listing Activity.\n0. Exit the program.\nSelection: ");

                int userSelection = int.Parse(Console.ReadLine());

                switch(userSelection)
                {

                    case 0:
                        
                        Console.Clear();

                        Console.WriteLine("Goodbye.");

                        running = false;

                        break;

                    case 1:

                        Console.Clear();

                        break;

                    case 2:

                        Console.Clear();

                        break;

                    case 3:

                        Console.Clear();

                        int count = 0;

                        int duration = 0;

                        ListingActivity listingActivity = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can inh a certain area.", duration, count);

                        break;

                    default:

                        Console.Clear();

                        Console.WriteLine("Invalid Selection, please select a valid option.");

                        break;
                    
                }

            }

            catch (Exception)
            {

                Console.Clear();

                Console.WriteLine("Invalid Selection, please select a valid option.");

            }

        }

    }

}