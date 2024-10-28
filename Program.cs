using EfCoreMigrationIssue;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateDefaultBuilder(args);
builder.ConfigureServices((_, services) =>
{
    services.AddDbContext<DemoDbContext>(options =>
        options
            .UseSqlServer("server=localhost; database=DemoDb; User Id=SA; Password=Tjipnl123!; encrypt=false")
            .ConfigureWarnings(w => w.Throw(RelationalEventId.MultipleCollectionIncludeWarning))
            .LogTo(Console.WriteLine, LogLevel.Warning));
    services.AddScoped<Run>();
});

var host = builder.Build();
var scope = host.Services.CreateScope();
scope.ServiceProvider.GetRequiredService<Run>().Execute();