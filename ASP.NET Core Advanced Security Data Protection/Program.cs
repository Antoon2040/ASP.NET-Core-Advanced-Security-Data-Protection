using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;

namespace ASP.NET_Core_Advanced_Security_Data_Protection;

class Program
{
    static void Main(string[] args)
    {
        // 1. Data protection services
        var servicesCollection = new ServiceCollection();
        servicesCollection.AddDataProtection();
        var services = servicesCollection.BuildServiceProvider();
        // 2. Create an instance of Idataprotection interface
        var dataProtectionProvider = services.GetService<IDataProtectionProvider>();
        var dataProtector = dataProtectionProvider.CreateProtector("FirstExample");
        Console.WriteLine("----------------------------Data Protector ---------------------------------");

        // 3. protect and unprotect a payload
        string title = "Welcome to this course!";
        Console.WriteLine($"Original value ={title}");

        var protectedTitle = dataProtector.Protect(title);
        Console.WriteLine($"Protected value ={protectedTitle}");

        var unProtectedTitle = dataProtector.Unprotect(protectedTitle);
        Console.WriteLine($"Unprotected value ={unProtectedTitle}");

        Console.WriteLine("----------------------------Password Hashing ---------------------------------");

        string password = "P@ss0rd!@";
        Console.ReadLine();
    }
}

