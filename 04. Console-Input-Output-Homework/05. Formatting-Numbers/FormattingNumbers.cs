using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number a:");
        int a = int.Parse(Console.ReadLine());
        string numbera = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("Enter number b:");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c:");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:0.000}|", a, numbera, b, c);
    }
}

