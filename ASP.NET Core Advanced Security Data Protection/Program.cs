using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using System.Linq.Expressions;
using System.Text;

namespace ASP.NET_Core_Advanced_Security_Data_Protection;

class Program
{
    static void Main(string[] args)
    {
        // 1. Data protection services
        var servicesCollection = new ServiceCollection();


        var provider = new EphemeralDataProtectionProvider();
        var protector = provider.CreateProtector($"Temp.Provider");

        string title = "Welcome to EphemeralDataProtectionProvider";
        var protectedData = protector.Protect(title);
        var unprotectedData = protector.Unprotect(protectedData);

        Console.WriteLine($"title:{title}");
        Console.WriteLine($"protectedData:{protectedData}");
        Console.WriteLine($"unprotectedData:{unprotectedData}");
        //servicesCollection.AddDataProtection()
        //    .SetDefaultKeyLifetime(TimeSpan.FromDays(10))
        //    .PersistKeysToFileSystem(new DirectoryInfo(@"c:\temp-encryption-keys"))
        //    .ProtectKeysWithDpapi();

        //var registryKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Keys\LinkedInLearning");
        //servicesCollection.AddDataProtection()
        //    .PersistKeysToRegistry(registryKey);

        //var services = servicesCollection.BuildServiceProvider();

        //var dataProtectionProvider = services.GetService<IDataProtectionProvider>();
        //var dataProtector = dataProtectionProvider.CreateProtector("Lifetme.Test1");

        //var dataprotected = dataProtector.Protect("Simple string");

        //var keyManagerService = services.GetService<IKeyManager>();

        //var allKeys = keyManagerService.GetAllKeys();

        //foreach ( var key in allKeys )
        //{
        //    Console.WriteLine($"Key Id: {key.KeyId} , Created: {key.CreationDate} , Expiration: {key.ExpirationDate} ," +
        //        $"Is Revoked: {key.IsRevoked}");
        //}
        //keyManagerService.RevokeAllKeys(DateTimeOffset.Now);
        //var allKeysAferReovked = keyManagerService.GetAllKeys();
        //foreach (var key in allKeysAferReovked)
        //{
        //    Console.WriteLine($"Key Id: {key.KeyId} , Created: {key.CreationDate} , Expiration: {key.ExpirationDate} ," +
        //        $"Is Revoked: {key.IsRevoked}");
        //}
        //string title = "Welcome to this course!";
        //Console.WriteLine($"Original value ={title}");
        //byte[] titleByte = Encoding.UTF8.GetBytes(title);

        //var protectedTitle = dataProtector.Protect(titleByte);
        //Console.WriteLine($"Protected value ={Convert.ToBase64String(protectedTitle)}");

        //var unProtectedTitle = dataProtector.Unprotect(protectedTitle);
        //Console.WriteLine($"Unprotected value ={Encoding.UTF8.GetString(unProtectedTitle)}");

        ////Get a reference to Keymanager
        //var keyManagerService = services.GetService<IKeyManager>();
        //keyManagerService.RevokeAllKeys(DateTimeOffset.Now);

        //try
        //{
        //    var tryUnprotect = dataProtector.Unprotect(protectedTitle);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //try
        //{
        //    IPersistedDataProtector persistedDataProtector = dataProtector as IPersistedDataProtector;
        //    if (persistedDataProtector == null)
        //        throw new Exception("Could not convert...");
        //    bool requiresMigration, wasRevoked;
        //    var unprotectedPatload = persistedDataProtector.DangerousUnprotect(
        //        protectedData: protectedTitle,
        //        ignoreRevocationErrors: true,
        //        requiresMigration: out requiresMigration,
        //        wasRevoked: out wasRevoked);
        //    Console.WriteLine($"requiresMigration ={requiresMigration}");
        //    Console.WriteLine($"wasRevoked ={wasRevoked}");
        //    String value = Encoding.UTF8.GetString(unprotectedPatload);
        //    Console.WriteLine($"Unprotected value ={Encoding.UTF8.GetString(unProtectedTitle)}");

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //Console.WriteLine("----------------------------Password Hashing ---------------------------------");

        //string password = "P@ss0rd!@";

        ////Generate a Random Salt
        //byte[] salt = new byte[128 / 8];
        //using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
        //{
        //    rng.GetBytes(salt);
        //}
        //string hashedpassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
        //    password: password,
        //    salt: salt,
        //    prf: KeyDerivationPrf.HMACSHA1,
        //    iterationCount:10000,
        //    numBytesRequested:256/8
        //    ));
        //Console.WriteLine($"Password - {password}");
        //Console.WriteLine($"Hashed Password - {hashedpassword}");

        //Console.WriteLine("----------------------Data Protector - Set Lifetime---------------------");


        //var _dataProtector = dataProtectionProvider.CreateProtector("FirstExample.WithLifeTime");
        //var _timeLimitedDataProtector = _dataProtector.ToTimeLimitedDataProtector();


        //// 3. protect and unprotect a payload
        //string _title = "Welcome to this course!";
        //Console.WriteLine($"Original value ={_title}");

        //var _protectedTitle = _timeLimitedDataProtector.Protect(title,lifetime:TimeSpan.FromSeconds(10));
        //Console.WriteLine($"Protected value ={_protectedTitle}");

        //var _unProtectedTitle = _timeLimitedDataProtector.Unprotect(_protectedTitle);
        //Console.WriteLine($"Unprotected value ={_unProtectedTitle}");

        //Console.WriteLine("Waiting 11 seconds...");
        //Thread.Sleep(11000);
        //_timeLimitedDataProtector.Unprotect(_protectedTitle);
        Console.ReadLine();
    }
}

