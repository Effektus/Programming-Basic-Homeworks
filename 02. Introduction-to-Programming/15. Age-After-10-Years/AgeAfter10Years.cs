﻿using System;

class AgeAfter10Years
{
    static void Main()
    {
        string input;
        DateTime birthday;
        Console.WriteLine("Enter Your Birthday in this Format(DD/MM/YY):");
        input = Console.ReadLine();
        birthday = Convert.ToDateTime(input);
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;
        if (birthday > today.AddYears(-age)) age--;
        Console.WriteLine("Now, you are {0} years old.", age);
        age = age + 10;
        Console.WriteLine("After 10 years you will be {0} years old", age);
    }
}

