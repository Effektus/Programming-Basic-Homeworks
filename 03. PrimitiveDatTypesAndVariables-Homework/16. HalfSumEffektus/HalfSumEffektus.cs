using System;

class HalfSumEffektus
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;

        for (int i = 0; i < n; i++)
        {
            int selection = int.Parse(Console.ReadLine());
            sum1 = sum1 + selection;
        }
        int sum2 = 0;

        for (int i = 0; i < n; i++)
        {
            int selection2 = int.Parse(Console.ReadLine());
            sum2 = sum2 + selection2;
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum = {0}", sum1);
        }
        else
        {
            int diff = Math.Abs(sum1 - sum2);
            Console.WriteLine("No, diff = {0}", diff);
        }
    }
}