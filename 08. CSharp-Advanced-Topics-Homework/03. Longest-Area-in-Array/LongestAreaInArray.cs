using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("Please enter the lenght of array: ");
        int n = int.Parse(Console.ReadLine());
        string[] str = new string[n];
        for (int i = 0; i < str.Length; i++)
        {
             str[i] = Console.ReadLine(); 
        }

    }
}

