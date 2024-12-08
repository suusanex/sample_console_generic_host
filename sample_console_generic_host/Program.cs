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

_ = Host.CreateDefaultBuilder(args)
    .ConfigureServices(ConfigureServices)
    .RunConsoleAsync();


void ConfigureServices(HostBuilderContext context, IServiceCollection services)
{
    services.AddHostedService<ConsoleHostedService>();

}