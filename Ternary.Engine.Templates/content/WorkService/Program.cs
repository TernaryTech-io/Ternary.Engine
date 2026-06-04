using Ternary.Engine.ServiceName;

var config = AppConfiguration.Create(args, (config, builder) =>
{
    builder.Services.AddSingleton<ServiceNameService>();
    builder.Services.AddHostedService<ServiceNameWorker>();
    return builder;
});

await config
    .Build()
    .RunAsync();
