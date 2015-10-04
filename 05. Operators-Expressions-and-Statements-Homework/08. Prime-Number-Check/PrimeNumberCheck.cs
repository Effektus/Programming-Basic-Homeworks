using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter integer number:");
            int num = int.Parse(Console.ReadLine());
            if (num >= 100)
            {
                Console.WriteLine("number is out of range!");
                return;
            }
            if (num < 2)
            {
                Console.WriteLine(false);
                return;
            }
            int i = 2;
            int composite = 0;
            bool checkNum = num % i != 0;
            for (; i <= Math.Sqrt(num); i++)
            {
                if (i != 1 || i != num)
                {
                    if (checkNum = num % i != 0)
                    {
                        continue;
                    }
                    else
                    {
                        composite++;
                        break;
                    }
                }
            }
            if (composite != 0)
            {
                Console.WriteLine(checkNum);
            }
            else
            {
                Console.WriteLine(checkNum);
            }
        }
    }

