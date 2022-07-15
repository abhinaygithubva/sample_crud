using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace sample_crud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
{
    return new HostBuilder()
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
            webBuilder.UseKestrel();
        }).ConfigureAppConfiguration((context, config) =>
        {
            config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);
            config.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: false);
            config.AddJsonFile("appsettings.k8s.json", optional: true, reloadOnChange: false);
            config.AddJsonFile("appsettings.secrets.json", optional: true, reloadOnChange: false);
        });
}
    }
}
