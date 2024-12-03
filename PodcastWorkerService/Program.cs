using PodcastWorkerService;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSystemd();
builder.Services.AddHostedService<Worker>();

var host = builder.Build();

await host.RunAsync();