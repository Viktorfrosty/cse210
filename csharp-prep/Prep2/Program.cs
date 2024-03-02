using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What's your score? ");
        string gradeString = Console.ReadLine();
        int gradeInt = int.Parse(gradeString);
        
        string letter = "";
        string modifier = "";
        
        if ( gradeInt >= 90 )
        {
            letter = "A";
        }
        else if ( gradeInt >= 80 && gradeInt < 90 )
        {
            letter = "B";
        }
        else if ( gradeInt >= 70 && gradeInt < 80 )
        {
            letter = "C";
        }
        else if ( gradeInt >= 60 && gradeInt < 70 )
        {
            letter = "D";
        }
        else if ( gradeInt < 60 )
        {
            letter = "F";
        }

        // Challenges

        int modifierValue = gradeInt % 10;

        if ( modifierValue <= 3 )
        {
            modifier = "-";
        }
        else if ( modifierValue >= 7 )
        {
            modifier = "+";
        }

        if ( gradeInt > 94 || gradeInt < 60 )
        {
            Console.WriteLine($"\nYour grade is: {letter}");
        }
        else
        {
            Console.WriteLine($"\nYour grade is: {letter}{modifier}");
        }        

        if ( gradeInt > 70 )
        {
            Console.WriteLine("Congratulations, you approved the course.");
        }
        else
        {
            Console.WriteLine("You failed the course. Don't worry, improve yourself and do it again.");
        }
    }
}