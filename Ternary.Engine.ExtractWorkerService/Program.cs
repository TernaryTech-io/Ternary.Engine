using Ternary.Engine.Custom;

var builder = TernaryAppBuilder.Create(args, (config, builder) =>
{
    //Add Services here
    builder.Services.AddSingleton<ExtractService>();
    builder.Services.AddHostedService<ExtractWorker>();
    return builder;
});

var app = builder.Build();
await app.RunAsync();


