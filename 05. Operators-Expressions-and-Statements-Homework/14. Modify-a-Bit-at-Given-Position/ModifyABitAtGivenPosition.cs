using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the value of bit:");
        int valueBit = int.Parse(Console.ReadLine());
        if (valueBit == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(result);
        }
    }
}

