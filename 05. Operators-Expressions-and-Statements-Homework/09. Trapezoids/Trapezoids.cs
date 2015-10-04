using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter the sides a and b and height h of trapezoid:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("Area is {0}", area);
    }
}
