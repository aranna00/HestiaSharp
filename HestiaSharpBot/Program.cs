using HestiaSharpBot;

new ConfigurationBuilder().AddEnvironmentVariables().Build();

var root = Directory.GetCurrentDirectory();
var dotenv = Path.Combine(root, "/src/.env");
DotEnv.Load(dotenv);

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();