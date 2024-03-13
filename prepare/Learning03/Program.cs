using System;
using ca1050;

class Program
{
    static void Main(string[] args)
    {

        /*Fraction test = new Fraction();
        int top = 0;
        int bottom = 0;
        int wholeNumber = 0;
        wholeNumber = test.SetTop(wholeNumber);
        top = test.SetTop(top);
        bottom = test.SetBottom(bottom);*/

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        //Fraction f2 = new Fraction(wholeNumber);
        //f2.GetTop();
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        //Fraction f3 = new Fraction(top, bottom);
        //f3.GetTop();
        //f3.GetBottom();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue()); 

    }
}