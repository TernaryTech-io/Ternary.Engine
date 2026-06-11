var builder = TernaryAppBuilder.Create(args, (config, builder) =>
{
    //Add Services here
    builder.Services.AddSingleton<MyExampleService>();
    builder.Services.AddHostedService<MyExampleWorker>();
    return builder;
});

var app = builder.Build();
await app.RunAsync();


