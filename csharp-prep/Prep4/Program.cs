using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = 1234567890;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while ( userNumber != 0 )
        {
            Console.Write("Insert a number:");
            string userInput = Console.ReadLine();

            userNumber = int.Parse(userInput);
            if ( userNumber != 0 )
            {
                numbers.Add(userNumber);
            }
            else
            {
                int listSum = 0;

                // challenge.
                int minimumPositiveNumber = 999999999;

                foreach ( int number in numbers )
                {
                    listSum += number;

                    // challenge.
                    if ( number > 0 && number < minimumPositiveNumber )
                    {
                        minimumPositiveNumber = number;
                    }
                }

                Console.WriteLine($"\nThe total is: {listSum}\nThe average is: {numbers.Average()}\nThe maximun number is: {numbers.Max()}\nThe minimum positive number is: {minimumPositiveNumber}\nThe sorted list is:");
                
                // challenge.
                numbers.Sort();
                foreach ( int number in numbers )
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}