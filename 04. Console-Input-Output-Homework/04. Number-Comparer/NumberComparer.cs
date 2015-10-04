using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter number a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Max(a, b);
            Console.WriteLine("Greater number is: {0}", result);
        }
    }

