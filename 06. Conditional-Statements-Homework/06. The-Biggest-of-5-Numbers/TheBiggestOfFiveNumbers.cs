﻿using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 numbers:");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double biggestNumber = a;

        if (b > a)
        {
            biggestNumber = b;
        }
        if (c > b && c > a)
        {
            biggestNumber = c;
        }
        if (d > c && d > b && d > a)
        {
            biggestNumber = d;
        }
        if (e > d && e > c && e > b && e > a)
        {
            biggestNumber = e;
        }
        Console.WriteLine("The Biggest of these 5 numbers is: {0}", biggestNumber);
    }
}
