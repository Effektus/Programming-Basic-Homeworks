using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter four-digit number: ");
        int n = int.Parse(Console.ReadLine());
        int a = (n / 1000) % 10;
        int b = (n / 100) % 10;
        int c = (n / 10) % 10;
        int d = n % 10;
        Console.WriteLine("The sum is: {0}", a + b + c + d);
        Console.WriteLine("Reversed order: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in the first position: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", a, c, b, d);
    }
}

