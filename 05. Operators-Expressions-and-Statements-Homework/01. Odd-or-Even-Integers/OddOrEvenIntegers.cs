using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        string result = n >= 0 ? "true" : "false";
        Console.WriteLine(result);
    }
}

