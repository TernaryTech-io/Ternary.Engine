using Ternary.Engine.Example;


var builder = TernaryAppBuilder.Create(args, (config, builder) =>
{
    //Add Services here
    builder.Services.AddSingleton<ExampleService>();
    builder.Services.AddHostedService<ExampleWorker>();
    return builder;
});

var app = builder.Build();
await app.RunAsync();


