using System;
using WCFClientDemo.UserServiceReference;

namespace WCFClientDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ServiceClient client = new ServiceClient();
            Console.WriteLine(client.PrintUserData("Paulina", "Sadowska", 23));
            UserData user = new UserData
            {
                firstName = "Rafal",
                surname = "Araszkiewicz",
                age = 24
            };
            Console.WriteLine(client.PrintUserDataObject(user));
            Console.WriteLine(client.PrintUserDataObject(null));
            user.firstName = null;
            Console.WriteLine(client.PrintUserDataObject(user));
            Console.ReadKey();
            client.Close();
        }
    }
}