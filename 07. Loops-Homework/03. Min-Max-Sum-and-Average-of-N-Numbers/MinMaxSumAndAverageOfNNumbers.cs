﻿using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of numbers:");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter an integer:");
            num[i] = int.Parse(Console.ReadLine());
            sum += num[i];
        }
        int min = num[0];
        int max = num[0];
        for (int i = 1; i < n; i++)
        {
            if (min > num[i])
            {
                min = num[i];
            }
            if (max < num[i])
            {
                max = num[i];
            }
        }
        Console.WriteLine("min={0}", min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("average={0:F2}", (double)sum / n);
    }
}

