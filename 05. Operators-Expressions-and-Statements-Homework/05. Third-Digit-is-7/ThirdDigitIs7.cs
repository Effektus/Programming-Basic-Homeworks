using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Please enter one integer: ");
        int n = int.Parse(Console.ReadLine());
        bool check = ((n / 100) % 10 == 7);
        Console.WriteLine("Third digit from right-to-left is 7 : {0}", check);
    }
}

