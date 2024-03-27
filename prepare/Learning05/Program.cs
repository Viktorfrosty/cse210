using System;
using ObjectData;

class Program
{

    static void Main(string[] args)
    {

        List<Shape> objectList = new List<Shape>();

        Square s1 = new Square("Yellow", 5);
        objectList.Add(s1);

        Rectangle s2 = new Rectangle("White", 7, 2);
        objectList.Add(s2);

        Circle s3 = new Circle("Red", 2);
        objectList.Add(s3);

        foreach (Shape element in objectList)
        {

            string color = element.GetColor();

            double area = element.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");

        }

    }

}