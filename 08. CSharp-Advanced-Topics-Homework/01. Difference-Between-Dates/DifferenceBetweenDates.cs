using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Please enter First date: ");

        string firstDate = Console.ReadLine();

        DateTime newfirstDate = Convert.ToDateTime(firstDate);

        Console.Write("Please enter Second date: ");

        string secondDate = Console.ReadLine();

        DateTime newsecondDate = Convert.ToDateTime(secondDate);

        Console.WriteLine("Days between: {0}", (newsecondDate - newfirstDate).TotalDays);
    }
}

