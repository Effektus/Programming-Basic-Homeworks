using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Please enter point x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter point y: ");
        double y = double.Parse(Console.ReadLine());
        bool check = Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= Math.Pow(2, 2);
        Console.WriteLine("The given point (x,  y) is inside a circle: {0}", check);
    }
}

