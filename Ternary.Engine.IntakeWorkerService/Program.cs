

var builder = TernaryAppBuilder.Create(args, (config, builder) =>
{
    //Add Services here
    builder.Services.AddSingleton<IntakeService>();
    builder.Services.AddHostedService<IntakeWorker>();
    return builder;
});

var app = builder.Build();
await app.RunAsync();


