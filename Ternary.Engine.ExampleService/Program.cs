
using Ternary.Engine.Example;


var config = AppConfiguration.Create(args, (config, builder) =>
{
    //Add Services here
    builder.Services.AddSingleton<ExampleService>();
    builder.Services.AddHostedService<ExampleWorker>();
    return builder;
});

await config
    .Build() //Return App
    .RunAsync(); // Runs App