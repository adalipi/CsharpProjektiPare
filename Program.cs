
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using ProjektiPare;
using Quartz.Logging;


IConfiguration configFile = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();

var services = new ServiceCollection();
services
    .AddLogging(log => { log.ClearProviders(); log.AddNLog(); })
    .AddSingleton(configFile)
    .AddScoped<TestLogim>()
    ;

using (var serviceProvider = services.BuildServiceProvider())
{
    var objekti = serviceProvider.GetRequiredService<TestLogim>();
    objekti.Shenim();
}

