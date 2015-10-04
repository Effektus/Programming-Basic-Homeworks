using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Please enter the lenght of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter 1 number:");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

