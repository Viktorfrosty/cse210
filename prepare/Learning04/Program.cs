using System;
using Assignments;

class Program
{

    static void Main(string[] args)
    {

        Assignment homework1 = new Assignment("Samuel Bennet", "Multiplication");

        MathAssingment homework2 = new MathAssingment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        WritingAssingment homework3 = new WritingAssingment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(homework1.GetSummary());

        Console.WriteLine(homework2.GetSummary());
        Console.WriteLine(homework2.GetHomework());

        Console.WriteLine(homework3.GetSummary());
        Console.WriteLine(homework3.GetWritingInformation());

    }

}