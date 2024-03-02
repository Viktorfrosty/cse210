using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("\nWhat's your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}