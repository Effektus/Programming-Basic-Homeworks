using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 numbers:");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.Write(a);
            if (b > c)
            {
                Console.Write(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.Write(c);
                Console.WriteLine(b);
            }
        }
        if (b > a && b > c)
        {
            Console.Write(b);
            if (a > c)
            {
                Console.Write(a);
                Console.WriteLine(c);
            }
            else
            {
                Console.Write(c);
                Console.WriteLine(a);
            }
        }
        if (c > a && c > b)
        {
            Console.Write(c);
            if (a > b)
            {
                Console.Write(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.Write(b);
                Console.WriteLine(a);
            }
        }
    }
}

