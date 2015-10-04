using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 numbers:");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b && b > c)
        {
            if (a > c)
            {
                Console.WriteLine("The biggest number from this 3 numbers is {0}", a);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("The biggest number from this 3 numbers is {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest number from this 3 numbers is {0}", c);
            }
        }
    }
}

