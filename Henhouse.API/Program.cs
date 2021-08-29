using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

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
                            .ConfigureLogging(logging =>
                            {
                            })
                            .ConfigureWebHostDefaults(webBuilder =>
                            {
                                _ = webBuilder.UseStartup<Startup>();
                            });
        }
    }
}
