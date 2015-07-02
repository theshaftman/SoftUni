using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        string managerName = managerFirstName + " " + managerLastName;
        Console.Write("Manager age: ");
        string checkAge = Console.ReadLine();
        byte number;
        byte age = 0;
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        if (byte.TryParse(checkAge, out number))
        {
            age = byte.Parse(checkAge);
        }

        if (phoneNumber == "")
        {
            phoneNumber = "(no phone)";
        }
        else if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }
        else if (webSite == "")
        {
            webSite = "(no web site)";
        }

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel: {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerName, age, managerPhone);
    }
}
