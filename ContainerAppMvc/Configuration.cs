using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc
{
    public static class Configuration
    {
        //appsettings.json'dan connection string i çekiyoruz.
        public static string ConnectionString { get {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
                return configuration.GetConnectionString("TodoAppDbConnectionString");
            } }
    }
}
