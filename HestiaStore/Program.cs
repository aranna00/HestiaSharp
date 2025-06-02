using HestiaStore;
using HestiaStore.Context;
using Microsoft.EntityFrameworkCore;

var builder = Host.CreateApplicationBuilder(args);
var databaseConnection = ContextConnection.GetDatabaseConnection();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(databaseConnection));

var host = builder.Build();
host.Run();