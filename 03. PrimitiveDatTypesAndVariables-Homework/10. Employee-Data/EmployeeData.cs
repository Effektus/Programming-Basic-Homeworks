using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Please enter first name of employee:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter last name of employee :");
        string lastName = Console.ReadLine();
        Console.WriteLine("Please enter age of employee:");
        string age = Console.ReadLine();
        Console.WriteLine("Please enter gender of employee");
        string gender = Console.ReadLine();
        Console.WriteLine("Please enter personal ID Number of employee:");
        long personalIDNumber = long.Parse(Console.ReadLine());
        int uniqueEmployeeNumber = 0;
        do
        {
            Console.WriteLine("Please enter unique employee number within scope (27560000…27569999):");
            uniqueEmployeeNumber = int.Parse(Console.ReadLine());
        } while (uniqueEmployeeNumber < 27560000 || uniqueEmployeeNumber > 27569999);
        Console.WriteLine();
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID Number: {0}", personalIDNumber);
        Console.WriteLine("Unique Employee Number: {0}", uniqueEmployeeNumber);
        Console.WriteLine();
    }
}

