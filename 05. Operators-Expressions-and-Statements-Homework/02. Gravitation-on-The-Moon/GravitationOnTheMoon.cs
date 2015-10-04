using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Please write how much you weigh on planet earth?");
        double weigh = double.Parse(Console.ReadLine());
        weigh = weigh * 17 / 100;
        Console.WriteLine("Your weigh on the moon will be : {0} kg", weigh);
    }
}

