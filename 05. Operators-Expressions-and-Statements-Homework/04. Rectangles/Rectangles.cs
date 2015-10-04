using System;

    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Please enter the width and height of rectangle:");
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + height);
            double area = height * width;
            Console.WriteLine("Perimeter is {0}", perimeter);
            Console.WriteLine("Area is {0}", area);
        }
    }

