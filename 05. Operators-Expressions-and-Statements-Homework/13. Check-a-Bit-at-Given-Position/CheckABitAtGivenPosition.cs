﻿using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        bool checkBit = bit == 1;
        Console.WriteLine(checkBit);
    }
}

