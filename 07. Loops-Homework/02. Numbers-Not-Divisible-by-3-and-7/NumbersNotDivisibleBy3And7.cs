﻿using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                i++;
            }
            if (i % 7 == 0)
            {
                i++;
            }
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}

