using System;

class PrintASequence
{
    static void Main()
    {
        // using for loop
        for (byte i = 2; i < 12; i++)
        {
            Console.WriteLine("{0}", i % 2 == 0 ? i : -i);
        }
    }
}

