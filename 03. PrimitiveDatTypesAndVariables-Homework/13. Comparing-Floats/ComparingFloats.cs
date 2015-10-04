using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Number a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Number b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        double eps = 0.000001;
        Console.WriteLine((b - a) <= eps);
        Console.ReadLine();
    }
}