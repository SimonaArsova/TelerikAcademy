using System;
namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string mаnagerFirstName = Console.ReadLine();
            string mаnagerLastName = Console.ReadLine();
            string mаnagerAge = Console.ReadLine();
            string mаnagerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            if (string.IsNullOrEmpty(faxNumber))
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + faxNumber);
            }
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})" , mаnagerFirstName, mаnagerLastName, mаnagerAge, mаnagerPhone);
        }
    }
}
