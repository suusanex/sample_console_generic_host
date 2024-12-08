global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using System.IO;
global using System.Diagnostics;
global using sample_console_generic_host;
using Microsoft.Extensions.Configuration;

_ = Host.CreateDefaultBuilder(args)
    .ConfigureLogging((context, logging) =>
    {
        logging.ClearProviders();
        logging.AddConfiguration(context.Configuration.GetSection("Logging"));
        logging.AddConsole();
    })
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddUserSecrets<Program>(optional: true, reloadOnChange: true);
    })
    .ConfigureServices(ConfigureServices)
    .RunConsoleAsync();


void ConfigureServices(HostBuilderContext context, IServiceCollection services)
{
    services.AddHostedService<ConsoleHostedService>();
    services.Configure<AppConfig>(context.Configuration.GetSection(nameof(AppConfig)));

}