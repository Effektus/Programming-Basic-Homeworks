using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("What is your Company name?");
        string companyName = Console.ReadLine();
        Console.WriteLine("What is your Company address?");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("What is your Company Phone number");
        string companyNumber = Console.ReadLine();
        Console.WriteLine("What is your Fax number?");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("What is your Web site?");
        string webSite = Console.ReadLine();
        Console.WriteLine("What is your Manager first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your Manager last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine("How old is your Manager?");
        string managerAge = Console.ReadLine();
        Console.WriteLine("What is your Manager phone number?");
        string manPhoneNumber = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Company Information:");
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel: {0}", companyNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age:{2}, {3})", firstName, lastName, managerAge, manPhoneNumber);
    }
}

