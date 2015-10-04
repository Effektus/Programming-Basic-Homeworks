using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Please enter the radius of circle:");
        double r = double.Parse(Console.ReadLine());
        double d = 2 * r;
        double pi = Math.PI;
        double perimeter = pi * d;
        double area = (r * r) * pi;
        Console.WriteLine("Perimeter is {0:F2}", perimeter);
        Console.WriteLine("Area is {0:F2}", area);
    }
}

