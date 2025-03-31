using Microsoft.Extensions.Configuration;

namespace Lupy.Infra.Authentication
{
    public static class Configuration
    {
        public static string PrivateKey 
        { 
            get 
            { 
                return Environment.GetEnvironmentVariable("PRIVATE_KEY")!;
            } 
        }
    }
}
