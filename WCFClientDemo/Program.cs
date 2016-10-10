using System;
using System.ServiceModel;
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

            try
            {
                Console.WriteLine(client.PrintUserDataObject(null));
            }
            catch (FaultException exception)
            {
                Console.WriteLine("ERROR: " + exception.Message);
            }

            try
            {
                user.firstName = null;
                Console.WriteLine(client.PrintUserDataObject(user));
            }
            catch (FaultException exception)
            {
                Console.WriteLine("ERROR: " + exception.Message);
            }

            Console.ReadKey();
            client.Close();
        }
    }
}