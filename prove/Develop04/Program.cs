/*
Exceeding Requirements:
- Added a try and cath block to handle invalid inputs.
- Added a way to select different questions during the reflection activity. Unfortunately, I had to add a list.Clear() method that practically broke the loop of this method to avoid duplicates. However, it only activates if the program is at the brink of creating an infinite loop during the search for unused indexes.
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

                        BreathingActivity breathingActivity = new BreathingActivity("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                        breathingActivity.DisplayStartingMessage();

                        breathingActivity.Run();

                        breathingActivity.DisplayEndingMessage();

                        break;

                    case 2:

                        Console.Clear();

                        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This Activity will help you  reflect on times in your life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                        reflectingActivity.DisplayStartingMessage();

                        reflectingActivity.Run();

                        reflectingActivity.DisplayEndingMessage();

                        break;

                    case 3:

                        Console.Clear();

                        ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                        listingActivity.DisplayStartingMessage();

                        listingActivity.Run();

                        listingActivity.DisplayEndingMessage();

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