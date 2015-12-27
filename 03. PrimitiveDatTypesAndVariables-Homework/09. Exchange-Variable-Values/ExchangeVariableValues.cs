using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before: \n a={0} \n b={1}", a, b);
        b = b - a;
        a = b + a;
        Console.WriteLine("After: \n a={0} \n b={1}", a, b);
    }
}

