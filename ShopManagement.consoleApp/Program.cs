using System;
using ShopManagement.consoleApp.Services;

namespace ShopManagement.consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var applicationService = new ApplicationService();
            while (true)
            {
                Console.WriteLine("Enter your command:");
                var command = Console.ReadLine();

                applicationService.Process(command);
            }
        }
    }
}
