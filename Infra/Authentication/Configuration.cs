using Microsoft.Extensions.Configuration;

namespace Lupy.Infra.Authentication
{
    public static class Configuration
    {
        public static string PrivateKey 
        { 
            get 
            { 
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build()["PrivateKey"]!;
            } 
        }
    }
}
