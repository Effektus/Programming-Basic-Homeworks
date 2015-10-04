using System;

class DivideBy7And5
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        bool divideby7 = n % 7 == 0 && n != 0;
        bool divideby5 = n % 5 == 0 && n != 0;
        Console.WriteLine(divideby7 & divideby5);
     }
}

