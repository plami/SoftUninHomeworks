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
            Console.Write("Manager First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager age: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string phone = Console.ReadLine();
        }
    }

