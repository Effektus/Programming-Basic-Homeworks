using System;

class PrintLongSequence
{
    static void Main()
    {
        // using for loop
        for (ushort i = 2; i < 1002; i++)
        {
            Console.WriteLine("{0}", i % 2 == 0 ? i : -i);
        }
    }
}

