using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Please enter a sign of Play Card");
        string playCard = Console.ReadLine();
        int number;
        if (int.TryParse(playCard, out number))
        {
            switch (number)
            {
                case 2: Console.WriteLine("yes");
                    break;
                case 3: Console.WriteLine("yes");
                    break;
                case 4: Console.WriteLine("yes");
                    break;
                case 5: Console.WriteLine("yes");
                    break;
                case 6: Console.WriteLine("yes");
                    break;
                case 7: Console.WriteLine("yes");
                    break;
                case 8: Console.WriteLine("yes");
                    break;
                case 9: Console.WriteLine("yes");
                    break;
                case 10: Console.WriteLine("yes");
                    break;
                default: Console.WriteLine("no");
                    break;
            }
        }
        else
        {
            switch (playCard)
            {
                case "j":
                case "J":
                case "k":
                case "K":
                case "q":
                case "Q":
                case "a":
                case "A":
                    Console.WriteLine("yes");
                    break;
                default: Console.WriteLine("no");
                    break;
            }
        }
    }
}
