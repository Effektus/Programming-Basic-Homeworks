using System;

class Joro2
{
    static void Main()
    {
        Console.WriteLine("What is the year leap (t) or not leap (f)");
        string year = Console.ReadLine();

        Console.WriteLine("How many holiday days are in this year?");  
        double holidays = int.Parse(Console.ReadLine());

        Console.WriteLine("How many weekend days in hometown are in this year?");
        int hometown = int.Parse(Console.ReadLine());

        int allWeeks = 52;
        int normalWeeks = (allWeeks - hometown) * 2 / 3;
        int leapYearDays;

        if (year == "t")
        {
            leapYearDays = 3;
        }
        else
        {
            leapYearDays = 0;
        }

        double totalPlays = normalWeeks + hometown + (holidays / 2) + leapYearDays;
        Console.WriteLine((int)totalPlays);
    }
}
