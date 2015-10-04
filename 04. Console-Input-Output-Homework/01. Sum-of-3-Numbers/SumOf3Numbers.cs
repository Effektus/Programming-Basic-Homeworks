using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please write 3 real numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} + {2}= {3}", a, b, c, a + b + c);
    }
}

