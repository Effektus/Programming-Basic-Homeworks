using System;

class DoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
            case 2:
                Console.WriteLine("Please enter a double:");
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                break;
            default:
                Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                break;
        }
        string str = Console.ReadLine();
        double n;

        if (double.TryParse(str, out n))
        {
            Console.WriteLine(++ n);
        }
        else
        {
            Console.WriteLine("{0}*", str);
        }
    }
}

