using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using System;

namespace Henhouse.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    /*if (context.HostingEnvironment.IsProduction())
                    {
                        var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("HenhouseUri")!);
                        _ = config.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());
                    }*/
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    _ = webBuilder.UseStartup<Startup>();
                });
        }
    }
}
