using System;

class Program
{
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        string userSelection = Console.ReadLine();
        int userNumber = int.Parse(userSelection);
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int squareNumber = userNumber * userNumber;
        return squareNumber;
    }
    static void DisplayResult(string userName,int squareNumber)
    {
        Console.WriteLine($"\n{userName}, the square of your number is: {squareNumber}");
    }
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName,squareNumber);
    }
}